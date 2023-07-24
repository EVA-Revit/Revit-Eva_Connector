using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Revit_Eva_Connector;
using Revit_Eva_Connector.Items;
using EVA_S;
using EVA_S.WPF;
using EVA_S.ExtensibleStorageExtension.ElementExtension;
using Autodesk.Revit.DB.Electrical;

namespace FromRevitConnector
{
    public class DevelopLoadFromRevit
    {
        public static Document doc { get; set; }
        //private static UIDocument uidoc;
        public static UIDocument uidoc { get; private set; }
        public static UIApplication uiApp { get; private set; }
        public static Application app { get; private set; }

        private static MainViewModel ParametersName { get; set; }

        public static Result SomeCode(ExternalCommandData commandData, ref string message)
        {
            try
            {
                uiApp = commandData.Application;
                uidoc = uiApp.ActiveUIDocument;
                app = uiApp.Application;
                doc = uidoc.Document;
                //Здесь пишется код или метод boolean
                if (!Load_from_Revit())
                {
                    return Result.Failed;
                }

                return Result.Succeeded;
            }
            catch (Exception ex)
            {
                message = ex.Message + ex.StackTrace;
                return Result.Failed;
            }

        }
        /// <summary>
        /// Метод в котором пишется основной код
        /// </summary>
        /// <returns></returns>
        static Boolean Load_from_Revit()
        {
            //TaskDialog.Show("New plagin", "Load from Revit");
            //Получение настроек выгрузки в DB


            Element el = GetStorageElement();

            ParametersNameEntity paramSettings = el.GetEntity<ParametersNameEntity>();

            //MainViewModel parametersName;

            if (paramSettings != null && paramSettings.StorageInProject) ParametersName = new MainViewModel(paramSettings);
            else
            {
                INIManager manager = new INIManager("C:\\ProgramData\\Autodesk\\Revit\\Addins\\2022\\EVA_Settings.ini");
                ParametersName = new MainViewModel();


                ReadAndWriteUserParameters.ReadFromIniUserParametrs(manager, ParametersName);
            }




            //В зависимости от настроек произвести сбор данных с ревит 
            //Получение всех панелей
           var panelsItems = FillingsPanelItems();

            //запись в json
            string path = "\\EVA_connector.json";
            var myPath = Path.GetTempPath() + path;
            if (File.Exists(myPath) == false)
            {
                var file = File.Create(myPath);
                file.Close();
            }
            else
            {
                File.Delete(myPath);
                var file = File.Create(myPath);
                file.Close();
            }

            var poe = new Revit_Eva_Connector.Items.CircuitItem();
            var uy = new Revit_Eva_Connector.Connector();
;          
            //ConnectorJson.MyPath = myPath;
            //ConnectorJson.SaveToDB(panelsItems, myPath);

            TaskDialog.Show("New plagin", myPath);

            return true;
        }
        public static Element GetStorageElement()
        {
            ProjectInfo pi = doc.ProjectInformation;
            return pi as Element;
        }

        private static List<PanelItem> FillingsPanelItems()
        {
            List<PanelItem> panelItems = new List<PanelItem>();

            FilteredElementCollector allBoards = new FilteredElementCollector(doc)
                           .OfCategory(BuiltInCategory.OST_ElectricalEquipment).WhereElementIsNotElementType();

            foreach (FamilyInstance board in allBoards)
            {
                //Метод забора всей инфы щита
                PanelItem panelItem = new PanelItem();

                panelItem.Name = board.Name;
                panelItem.Id = board.Id.IntegerValue;
                panelItem.PSet = board.LookupParameter(ParametersName.ParamPSet)?.AsString();

                panelItem.Mode1 = board.LookupParameter(ParametersName.ParamMode1)?.AsString();
                panelItem.Kc1 = board.LookupParameter(ParametersName.ParamKc1)?.AsString();
                panelItem.Pcurrent1 = board.LookupParameter(ParametersName.ParamScurrent1)?.AsString();
                panelItem.Scurrent1 = board.LookupParameter(ParametersName.ParamScurrent1)?.AsString();
                panelItem.Cos1 = board.LookupParameter(ParametersName.ParamCos1)?.AsString();
                panelItem.Icurrent1 = board.LookupParameter(ParametersName.ParamIcurrent1)?.AsString();

                panelItem.Mode2 = board.LookupParameter(ParametersName.ParamMode2)?.AsString();
                panelItem.Kc2 = board.LookupParameter(ParametersName.ParamKc2)?.AsString();
                panelItem.Pcurrent2 = board.LookupParameter(ParametersName.ParamScurrent2)?.AsString();
                panelItem.Scurrent2 = board.LookupParameter(ParametersName.ParamScurrent2)?.AsString();
                panelItem.Cos2 = board.LookupParameter(ParametersName.ParamCos2)?.AsString();
                panelItem.Icurrent2 = board.LookupParameter(ParametersName.ParamIcurrent2)?.AsString();

                panelItem.Mode3 = board.LookupParameter(ParametersName.ParamMode3)?.AsString();
                panelItem.Kc3 = board.LookupParameter(ParametersName.ParamKc3)?.AsString();
                panelItem.Pcurrent3 = board.LookupParameter(ParametersName.ParamScurrent3)?.AsString();
                panelItem.Scurrent3 = board.LookupParameter(ParametersName.ParamScurrent3)?.AsString();
                panelItem.Cos3 = board.LookupParameter(ParametersName.ParamCos3)?.AsString();
                panelItem.Icurrent3 = board.LookupParameter(ParametersName.ParamIcurrent3)?.AsString();

                panelItem.Mode4 = board.LookupParameter(ParametersName.ParamMode4)?.AsString();
                panelItem.Kc4 = board.LookupParameter(ParametersName.ParamKc4)?.AsString();
                panelItem.Pcurrent4 = board.LookupParameter(ParametersName.ParamScurrent4)?.AsString();
                panelItem.Scurrent4 = board.LookupParameter(ParametersName.ParamScurrent4)?.AsString();
                panelItem.Cos4 = board.LookupParameter(ParametersName.ParamCos4)?.AsString();
                panelItem.Icurrent4 = board.LookupParameter(ParametersName.ParamIcurrent4)?.AsString();


                //panelItem.CircuitItems = FillingCircItems(board);


                panelItems.Add(panelItem);

            }

            

            return panelItems;
        }
        private static List<CircuitItem> FillingCircItems(FamilyInstance board)
        {
            var circuitlItems = new List<CircuitItem>();
            var fullCircuits = board.MEPModel.GetElectricalSystems(); //Получение всех цепей щита
            foreach (ElectricalSystem circ in fullCircuits)
            {
                //метод заполнения параметров цепей
                if (board.Name == circ.PanelName) continue;//если цепь питаюшая панель
                CircuitItem circuitItem = new CircuitItem();
                circuitItem.Name = circ.Name;
                circuitItem.Id = circ.Id.IntegerValue;
                circuitItem.PSet = circ.LookupParameter(ParametersName.ParamPSet)?.AsString();
                circuitItem.TypeLoadName = circ.LookupParameter(ParametersName.ParamTypeLoadName)?.AsString();
                circuitItem.LoadName = circ.LookupParameter(ParametersName.ParamLoadName)?.AsString();
                circuitItem.AccountingModeLoads = circ.LookupParameter(ParametersName.ParamAccountingModeLoads)?.AsString();
                circuitItem.AccountingModeLoads = circ.LookupParameter(ParametersName.ParamAccountingModeLoads)?.AsString();
                circuitItem.PhaseConnecting = circ.LookupParameter(ParametersName.ParamPhaseConnecting)?.AsString();
                circuitItem.CosF = circ.LookupParameter(ParametersName.ParamCosF)?.AsString();
                circuitItem.Pcurrent = circ.LookupParameter(ParametersName.ParamPcurrent)?.AsString();
                circuitItem.Icurrent = circ.LookupParameter(ParametersName.ParamIcurrent)?.AsString();
                circuitItem.CableDesignation = circ.LookupParameter(ParametersName.ParamCableDesignation)?.AsString();
                circuitItem.SingleOrMultiple = circ.LookupParameter(ParametersName.ParamSingleOrMultiple)?.AsString();
                circuitItem.MarkCable = circ.LookupParameter(ParametersName.ParamMarkCable)?.AsString();
                circuitItem.SectionCable11 = circ.LookupParameter(ParametersName.ParamSectionCable11)?.AsString();
                circuitItem.SectionCable12 = circ.LookupParameter(ParametersName.ParamSectionCable12)?.AsString();
                circuitItem.SectionCable13 = circ.LookupParameter(ParametersName.ParamSectionCable13)?.AsString();
                circuitItem.FactLenCable1 = circ.LookupParameter(ParametersName.ParamFactLenCable1)?.AsString();
                circuitItem.SectionCable21 = circ.LookupParameter(ParametersName.ParamSectionCable21)?.AsString();
                circuitItem.SectionCable22 = circ.LookupParameter(ParametersName.ParamSectionCable22)?.AsString();
                circuitItem.SectionCable23 = circ.LookupParameter(ParametersName.ParamSectionCable23)?.AsString();
                circuitItem.FactLenCable2 = circ.LookupParameter(ParametersName.ParamFactLenCable2)?.AsString();
                circuitItem.LenForCountTKZ = circ.LookupParameter(ParametersName.ParamLenForCountTKZ)?.AsString();
                circuitItem.LenCableCurrent = circ.LookupParameter(ParametersName.ParamLenCableCurrent)?.AsString();
                circuitItem.AdmissibleLoss = circ.LookupParameter(ParametersName.ParamAdmissibleLoss)?.AsString();
                circuitItem.CurrentLoss = circ.LookupParameter(ParametersName.ParamCurrentLoss)?.AsString();
                circuitItem.SetWorkWinterSummer = circ.LookupParameter(ParametersName.ParamSetWorkWinterSummer)?.AsString();
                circuitItem.CurrentTKZendLine = circ.LookupParameter(ParametersName.ParamCurrentTKZendLine)?.AsString();
                circuitItem.CountElements = circ.LookupParameter(ParametersName.ParamCountElements)?.AsString();
                circuitItem.TypePipe = circ.LookupParameter(ParametersName.ParamTypePipe)?.AsString();
                circuitItem.DiameterPipe = circ.LookupParameter(ParametersName.ParamDiameterPipe)?.AsString();
                circuitItem.LenPipe = circ.LookupParameter(ParametersName.ParamLenPipe)?.AsString();
                circuitItem.LenCableInTray = circ.LookupParameter(ParametersName.ParamLenCableInTray)?.AsString();
                circuitItem.Room = circ.LookupParameter(ParametersName.ParamRoom)?.AsString();
                circuitItem.TextName = circ.LookupParameter(ParametersName.ParamTextName)?.AsString();
                circuitItem.DoubleName = circ.LookupParameter(ParametersName.ParamDoubleName)?.AsString();
                circuitItem.Project = circ.LookupParameter(ParametersName.ParamProject)?.AsString();
                circuitItem.Functional = circ.LookupParameter(ParametersName.ParamFunctional)?.AsString();

                circuitlItems.Add(circuitItem);
            }


            return circuitlItems;
        }

    }
}
