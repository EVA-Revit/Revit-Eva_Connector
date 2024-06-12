namespace Revit_Eva_Connector.Services;

using System;
using Autodesk.Revit.DB;
using UserConfigs;

public class DataParametersStorageService
{
    private readonly Guid _schemaCircuitPatametersGuid = new("306f94d1-13d1-46c9-b76b-e60a7fdae6c1");
    private readonly Guid _schemaPanelPatametersGuid = new("9c5eeee2-4932-43b8-8fb3-9f715112700c");
    private readonly Guid _schemaConsumerPatametersGuid = new("958fa6e7-685e-4407-b094-610a7545def5");
    private const string SchemaName = "EVA_ParametersSchema";
    private const string CircuitFieldName = "CircuitParametersData";
    private const string PanelFieldName = "PanelParametersData";
    private const string ConsumerFieldName = "ConsumerParametersData";

    public void SaveCircuitParameters(Document doc, CircuitParametersUserConfig circuitParameters)
    {
        EvaAPI.Services.DataStorageService.Save(doc, circuitParameters, _schemaCircuitPatametersGuid, SchemaName, CircuitFieldName);
    }

    public CircuitParametersUserConfig LoadCircuitParameters(Document doc)
    {
        return EvaAPI.Services.DataStorageService.Load<CircuitParametersUserConfig>(doc, _schemaCircuitPatametersGuid, SchemaName, CircuitFieldName);
    }

    public void SavePanelParameters(Document doc, PanelParametersUserConfig panelParameters)
    {
        EvaAPI.Services.DataStorageService.Save(doc, panelParameters, _schemaPanelPatametersGuid, SchemaName, PanelFieldName);
    }

    public PanelParametersUserConfig LoadPanelParameters(Document doc)
    {
        return EvaAPI.Services.DataStorageService.Load<PanelParametersUserConfig>(doc, _schemaPanelPatametersGuid, SchemaName, PanelFieldName);
    }

    public void SaveConsumerParameters(Document doc, ConsumerParametersUserConfig consumerParameters)
    {
        EvaAPI.Services.DataStorageService.Save(doc, consumerParameters, _schemaConsumerPatametersGuid, SchemaName, ConsumerFieldName);
    }

    public ConsumerParametersUserConfig LoadConsumerParameters(Document doc)
    {
        return EvaAPI.Services.DataStorageService.Load<ConsumerParametersUserConfig>(doc, _schemaConsumerPatametersGuid, SchemaName, ConsumerFieldName);
    }
}