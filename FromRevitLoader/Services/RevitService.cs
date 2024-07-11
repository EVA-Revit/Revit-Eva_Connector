namespace FromRevitLoader.Services;

using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Electrical;
using Newtonsoft.Json.Linq;
using Revit_Eva_Connector.Items;
using Revit_Eva_Connector.Services;
using Revit_Eva_Connector.UserConfigs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Revit_Eva_Connector.Enums;

public class RevitService
{
    private CircuitParametersUserConfig _ciruitParametersUserConfig;
    private PanelParametersUserConfig _panelParametersUserConfig;
    private ConsumerParametersUserConfig _consumerParametersUserConfig;
    private readonly DataParametersStorageService _dataParametersStorageService;
    private readonly Document _doc;
    private readonly IEnumerable<FamilyInstance> _panelsInRevit;

    public RevitService(Document doc)
    {
        _dataParametersStorageService = new DataParametersStorageService();
        _doc = doc;
        _panelsInRevit = new FilteredElementCollector(_doc)
            .OfCategory(BuiltInCategory.OST_ElectricalEquipment)
            .WhereElementIsNotElementType()
            .OfType<FamilyInstance>();
    }

    public void FieldUserConfigs()
    {
        _ciruitParametersUserConfig = _dataParametersStorageService.LoadCircuitParameters(_doc);
        _panelParametersUserConfig = _dataParametersStorageService.LoadPanelParameters(_doc);
        _consumerParametersUserConfig = _dataParametersStorageService.LoadConsumerParameters(_doc);
    }

    public List<PanelItem> GetPanels()
    {
        var panels = new List<PanelItem>();
        
       
        foreach (var panel in _panelsInRevit)
        {
            var panelItem = GetPanelItem(panel);
            panels.Add(panelItem);
        }

        return panels;
    }

    public void SetPanels(List<PanelItem> panels)
    {

        foreach (var panelItem in panels)
        {
            var panel = _panelsInRevit.FirstOrDefault(p => p.Name == panelItem.Name);
            if (panel == null)
                continue;

            using var transaction = new Transaction(_doc, "Set panel");
            {
                transaction.Start();

                SetPanel(panel, panelItem);

                transaction.Commit();
            }
        }
    }

    private void SetPanel(FamilyInstance panel, PanelItem panelItem)
    {
        PropertyInfo[] panelItemProperties = typeof(PanelItem).GetProperties();
        PropertyInfo[] panelParametersUserConfigProperties = typeof(PanelParametersUserConfig).GetProperties();

        foreach (var panelItemProperty in panelItemProperties)
        {
            if (panelItemProperty.GetValue(panelItem) is not string value)
                continue;

            if (value == "CircuitItems")
                continue;
            
            var isLoadProperty = panelParametersUserConfigProperties.FirstOrDefault(p => p.Name == panelItemProperty.Name + "In");

            if (isLoadProperty != null && (bool)isLoadProperty.GetValue(_panelParametersUserConfig))
            {
                var userConfigProperty = panelParametersUserConfigProperties.FirstOrDefault(p => p.Name == panelItemProperty.Name);

                if (userConfigProperty == null)
                    continue;

                var panelRevitProperty = panel.Parameters
                    .OfType<Parameter>()
                    .FirstOrDefault(p => p.Definition.Name == (string)userConfigProperty.GetValue(_panelParametersUserConfig));

                if (panelRevitProperty == null)
                    continue;

                SetValue(panelRevitProperty, value);
            }
        }

        SetCircuits(panel, panelItem.CircuitItems);
    }

    private void SetCircuits(FamilyInstance panel, List<CircuitItem> circuits)
    {
        foreach (var circuitItem in circuits)
        {

#if R2020 || R2021
            var circuit = panel.MEPModel.ElectricalSystems.OfType<ElectricalSystem>().FirstOrDefault(c => c.Id.IntegerValue == circuitItem.Id);
#elif R2022 || R2023
            var circuit = panel.MEPModel.GetElectricalSystems().FirstOrDefault(c => c.Id.IntegerValue == circuitItem.Id);
#else
            var circuit = panel.MEPModel.GetElectricalSystems().FirstOrDefault(c => c.Id.Value == circuitItem.Id);
#endif

            if (circuit == null)
                continue;
            SetCircuit(circuit, circuitItem);
        }
    }

    private void SetCircuit(ElectricalSystem circuit, CircuitItem circuitItem)
    {
        PropertyInfo[] circuitItemProperties = typeof(CircuitItem).GetProperties();
        PropertyInfo[] circuitParametersUserConfigProperties = typeof(CircuitParametersUserConfig).GetProperties();

        foreach (var circuitItemProperty in circuitItemProperties)
        {
            if (circuitItemProperty.GetValue(circuitItem) is not string value)
                continue;

            var isLoadProperty = circuitParametersUserConfigProperties.FirstOrDefault(p => p.Name == circuitItemProperty.Name + "In");

            if (isLoadProperty != null && (bool)isLoadProperty.GetValue(_ciruitParametersUserConfig))
            {
                var userConfigProperty = circuitParametersUserConfigProperties.FirstOrDefault(p => p.Name == circuitItemProperty.Name);

                if (userConfigProperty == null)
                    continue;

                var circuitRevitProperty = circuit.Parameters
                    .OfType<Parameter>()
                    .FirstOrDefault(p => p.Definition.Name == (string)userConfigProperty.GetValue(_ciruitParametersUserConfig));

                if (circuitRevitProperty == null)
                    continue;

                SetValue(circuitRevitProperty, value);
            }
        }
    }

    private void SetValue(Parameter parameter, string value)
    {
        switch (parameter.StorageType)
        {
            case StorageType.Double:
                var valueDouble = double.Parse(value, CultureInfo.InvariantCulture);
                if (Math.Abs(parameter.AsDouble() - valueDouble) > 0.0001)
                    parameter.Set(valueDouble);
                break;
            case StorageType.Integer:
                var valueInt = int.Parse(value);
                if (parameter.AsInteger() != valueInt)
                    parameter.Set(valueInt);
                break;
            case StorageType.String:
                if (parameter.AsString() != value)
                    parameter.Set(value);
                break;
        }
    }

    private PanelItem GetPanelItem(FamilyInstance panel)
    {
        var panelItem = new PanelItem
        {
            Name = panel.Name
        };

#if R2020 || R2021 || R2022 || R2023
        panelItem.Id = panel.Id.IntegerValue;
#else
        panelItem.Id = panel.Id.Value;
#endif


        PropertyInfo[] panelItemProperties = typeof(PanelItem).GetProperties();
        PropertyInfo[] panelParametersUserConfigProperties = typeof(PanelParametersUserConfig).GetProperties();

        foreach (var panelItemProperty in panelItemProperties)
        {
            if (panelItemProperty.Name == "CircuitItems")
            {
                var circuits = GetCircuits(panel);
                panelItem.CircuitItems = circuits;
                continue;
            }

            var userConfigProperty = panelParametersUserConfigProperties.FirstOrDefault(p => p.Name == panelItemProperty.Name);
            if (userConfigProperty == null) 
                continue;

            if (userConfigProperty.GetValue(_panelParametersUserConfig) is string value)
            {
                var parameter = panel.Parameters.OfType<Parameter>().FirstOrDefault(p => p.Definition.Name == value);
                if (parameter != null)
                    switch (parameter.StorageType)
                    {
                        case StorageType.Double:
                            panelItemProperty.SetValue(panelItem, parameter.AsDouble().ToString(CultureInfo.InvariantCulture));
                            break;
                        case StorageType.Integer:
#if R2019 || R2020 || R2021
                            if (parameter.Definition.ParameterType == ParameterType.YesNo)
#else
                            if (parameter.Definition.GetDataType() == SpecTypeId.Boolean.YesNo)
#endif
                            {
                                if (parameter.AsInteger() == 0)
                                {
                                    panelItemProperty.SetValue(panelItem, false);
                                }
                                else
                                {
                                    panelItemProperty.SetValue(panelItem, true);
                                }
                            }
                            else
                            {
                                panelItemProperty.SetValue(panelItem, parameter.AsInteger().ToString());
                            }
                           
                            break;
                        case StorageType.String:
                            panelItemProperty.SetValue(panelItem, parameter.AsString());
                            break;
                    }
            }

            if (userConfigProperty.GetValue(_panelParametersUserConfig) is bool valueBool)
            {
                panelItemProperty.SetValue(panelItem, valueBool);
            }
        }

        return panelItem;
    }

    private List<CircuitItem> GetCircuits(FamilyInstance panel)
    {
        var circuits = new List<CircuitItem>();
#if R2020
        var allCircuits = panel.MEPModel.ElectricalSystems.OfType<ElectricalSystem>();
#else
        var allCircuits = panel.MEPModel.GetElectricalSystems();
#endif

        foreach (var circuit in allCircuits)
        {
            if (panel.Name != circuit.PanelName) 
                continue;
            var circuitItem = GetCircuitItem(circuit);
            circuits.Add(circuitItem);
        }

        return circuits;
    }

    private CircuitItem GetCircuitItem(ElectricalSystem circuit)
    {
        var circuitItem = new CircuitItem();
#if R2020 || R2021 || R2022 || R2023
        circuitItem.Id = circuit.Id.IntegerValue;
#else
        circuitItem.Id = circuit.Id.Value;
#endif

        PropertyInfo[] circuitItemProperties = typeof(CircuitItem).GetProperties();
        PropertyInfo[] circuitParametersUserConfigProperties = typeof(CircuitParametersUserConfig).GetProperties();

        foreach (var circuitItemProperty in circuitItemProperties)
        {
            var userConfigProperty = circuitParametersUserConfigProperties.FirstOrDefault(p => p.Name == circuitItemProperty.Name);
            if (userConfigProperty != null)
            {
                if (userConfigProperty.GetValue(_ciruitParametersUserConfig) is string value)
                {
                    var parameter = circuit.Parameters.OfType<Parameter>().FirstOrDefault(p => p.Definition.Name == value);
                    if (parameter != null)
                    {
                        switch (parameter.StorageType)
                        {
                            case StorageType.Double:
                                circuitItemProperty.SetValue(circuitItem, parameter.AsDouble().ToString(CultureInfo.InvariantCulture));
                                break;
                            case StorageType.Integer:
                                circuitItemProperty.SetValue(circuitItem, parameter.AsInteger().ToString());
                                break;
                            case StorageType.String:
                                circuitItemProperty.SetValue(circuitItem, parameter.AsString());
                                break;
                        }

                    }
                }

                if (userConfigProperty.GetValue(_ciruitParametersUserConfig) is bool valueBool)
                {
                    circuitItemProperty.SetValue(circuitItem, valueBool);
                }
            }

            if (circuitItemProperty.Name == nameof(CircuitItem.TypeConsumer))
            {

                circuitItem.TypeConsumer = GetConsumerType(circuit);
            }

        }

        return circuitItem;
    }

    /// <summary>
    /// Определяет потребитель панель или нет
    /// </summary>
    /// <param name="circuit"></param>
    /// <returns></returns>
    private TypeConsumer GetConsumerType(ElectricalSystem circuit)
    {
        // Получить категорию OST_ElectricalEquipment
        var electricalEquipmentCategory = Category.GetCategory(_doc, BuiltInCategory.OST_ElectricalEquipment);

        IEnumerable<Element> elementsInCircuit = circuit.Elements.OfType<Element>();
        
        var electricalEquipment = elementsInCircuit.Where(element => element.Category.Id == electricalEquipmentCategory.Id).ToList();

        foreach (var element in electricalEquipment)
        {
            if (element.LookupParameter("EVA_Вложенный_щит")?.AsInteger() == 1)
            {
                return TypeConsumer.SubPanel;
            }
        }

        // TODO: Проверить, что элементы могут быть в исключении, как потребители
        if (electricalEquipment.Any())
        {
            return TypeConsumer.Panel;
        }
      
        return TypeConsumer.General;
    }
}