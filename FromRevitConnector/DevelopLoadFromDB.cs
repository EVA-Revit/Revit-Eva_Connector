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
    public class DevelopLoadFromDB
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
                if (!CodeMetod())
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
        static Boolean CodeMetod()
        {
            //TaskDialog.Show("New plagin", "Load from DB");

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






            //чтение из json
            string path = "\\EVA_connector_Excel.json";
            var temppath = Environment.GetEnvironmentVariable("TMP", EnvironmentVariableTarget.User);
            //var temppath = Path.GetTempPath();
            var myPath = temppath + path;
            if (File.Exists(myPath) == false)
            {
                TaskDialog.Show("Предупреждение", "Отсутствует выгрузка");
                return false;
            }

            ConnectorJson.MyPath = myPath;

            List<PanelItem> PanelItems = ConnectorJson.ReadAllFromDB();


            using (Transaction newTran = new Transaction(doc, "Запись параметров EVA в панели и цепи"))
            {
                newTran.Start();
                WritePanelItems(PanelItems);
                newTran.Commit();
            }

                 
        



            return true;
        }
        public static Element GetStorageElement()
        {
            ProjectInfo pi = doc.ProjectInformation;
            return pi as Element;
        }


        private static void WritePanelItems(List<PanelItem> panelItems)
        {
            

            FilteredElementCollector allBoards = new FilteredElementCollector(doc)
                           .OfCategory(BuiltInCategory.OST_ElectricalEquipment).WhereElementIsNotElementType();

            foreach (PanelItem panelItem in panelItems)
            {
                var board = allBoards.FirstOrDefault(x=>x.Id.IntegerValue == panelItem.Id);
                if (board == null) continue;



                ////Метод забора всей инфы щита
                ////panelItem.Name = board.Name;

                if (ParametersName.InPSet) board.LookupParameter(ParametersName.ParamPSet)?.Set(panelItem.PSet);

                if(ParametersName.InMode1) board.LookupParameter(ParametersName.ParamMode1)?.Set(panelItem.Mode1);
                if(ParametersName.InKc1) board.LookupParameter(ParametersName.ParamKc1)?.Set(panelItem.Kc1);
                if(ParametersName.InPcurrent1) board.LookupParameter(ParametersName.ParamPcurrent1)?.Set(panelItem.Pcurrent1);
                if(ParametersName.InScurrent1) board.LookupParameter(ParametersName.ParamScurrent1)?.Set(panelItem.Scurrent1);
                if(ParametersName.InCos1) board.LookupParameter(ParametersName.ParamCos1)?.Set(panelItem.Cos1);
                if(ParametersName.InIcurrent1) board.LookupParameter(ParametersName.ParamIcurrent1)?.Set(panelItem.Icurrent1);

                if (ParametersName.InMode1) board.LookupParameter(ParametersName.ParamMode2)?.Set(panelItem.Mode2);
                if (ParametersName.InKc1) board.LookupParameter(ParametersName.ParamKc2)?.Set(panelItem.Kc2);
                if (ParametersName.InPcurrent1) board.LookupParameter(ParametersName.ParamPcurrent2)?.Set(panelItem.Pcurrent2);
                if (ParametersName.InScurrent1) board.LookupParameter(ParametersName.ParamScurrent2)?.Set(panelItem.Scurrent2);
                if (ParametersName.InCos1) board.LookupParameter(ParametersName.ParamCos2)?.Set(panelItem.Cos2);
                if (ParametersName.InIcurrent1) board.LookupParameter(ParametersName.ParamIcurrent2)?.Set(panelItem.Icurrent2);

                if (ParametersName.InMode1) board.LookupParameter(ParametersName.ParamMode3)?.Set(panelItem.Mode3);
                if (ParametersName.InKc1) board.LookupParameter(ParametersName.ParamKc3)?.Set(panelItem.Kc3);
                if (ParametersName.InPcurrent1) board.LookupParameter(ParametersName.ParamPcurrent3)?.Set(panelItem.Pcurrent3);
                if (ParametersName.InScurrent1) board.LookupParameter(ParametersName.ParamScurrent3)?.Set(panelItem.Scurrent3);
                if (ParametersName.InCos1) board.LookupParameter(ParametersName.ParamCos3)?.Set(panelItem.Cos3);
                if (ParametersName.InIcurrent1) board.LookupParameter(ParametersName.ParamIcurrent3)?.Set(panelItem.Icurrent3);

                if (ParametersName.InMode1) board.LookupParameter(ParametersName.ParamMode4)?.Set(panelItem.Mode4);
                if (ParametersName.InKc1) board.LookupParameter(ParametersName.ParamKc4)?.Set(panelItem.Kc4);
                if (ParametersName.InPcurrent1) board.LookupParameter(ParametersName.ParamPcurrent4)?.Set(panelItem.Pcurrent4);
                if (ParametersName.InScurrent1) board.LookupParameter(ParametersName.ParamScurrent4)?.Set(panelItem.Scurrent4);
                if (ParametersName.InCos1) board.LookupParameter(ParametersName.ParamCos4)?.Set(panelItem.Cos4);
                if (ParametersName.InIcurrent1) board.LookupParameter(ParametersName.ParamIcurrent4)?.Set(panelItem.Icurrent4);


                ////panelItem.CircuitItems = FillingCircItems(board);
                WritingCircItems(board as FamilyInstance, panelItem.CircuitItems);


            }



           
        }

        private static void WritingCircItems(FamilyInstance board, List<CircuitItem> circuitItems)
        {
            var fullCircuits = board.MEPModel.GetElectricalSystems(); //Получение всех цепей щита

            foreach (var circuitItem in circuitItems)
            {
                var circ = fullCircuits.FirstOrDefault(x => x.Id.IntegerValue == circuitItem.Id);
                if (circ == null) continue;

                if(ParametersName.InPSet) circ.LookupParameter(ParametersName.ParamPSet)?.Set(circuitItem.PSet);
                if(ParametersName.InTypeLoadName) circ.LookupParameter(ParametersName.ParamTypeLoadName)?.Set(circuitItem.TypeLoadName);
                if(ParametersName.InLoadName) circ.LookupParameter(ParametersName.ParamLoadName)?.Set(circuitItem.LoadName);
                if(ParametersName.InAccountingModeLoads) circ.LookupParameter(ParametersName.ParamAccountingModeLoads)?.Set(circuitItem.AccountingModeLoads);

                if(ParametersName.InPhaseConnecting) circ.LookupParameter(ParametersName.ParamPhaseConnecting)?.Set(circuitItem.PhaseConnecting);
                if(ParametersName.InCosF) circ.LookupParameter(ParametersName.ParamCosF)?.Set(circuitItem.CosF);
                if(ParametersName.InPcurrent) circ.LookupParameter(ParametersName.ParamPcurrent)?.Set(circuitItem.Pcurrent);
                if(ParametersName.InIcurrent) circ.LookupParameter(ParametersName.ParamIcurrent)?.Set(circuitItem.Icurrent);
                if(ParametersName.InCableDesignation) circ.LookupParameter(ParametersName.ParamCableDesignation)?.Set(circuitItem.CableDesignation);
                if(ParametersName.InSingleOrMultiple) circ.LookupParameter(ParametersName.ParamSingleOrMultiple)?.Set(circuitItem.SingleOrMultiple);
                if(ParametersName.InMarkCable) circ.LookupParameter(ParametersName.ParamMarkCable)?.Set(circuitItem.MarkCable);
                if(ParametersName.InSectionCable1) circ.LookupParameter(ParametersName.ParamSectionCable11)?.Set(circuitItem.SectionCable11);
                if(ParametersName.InSectionCable1) circ.LookupParameter(ParametersName.ParamSectionCable12)?.Set(circuitItem.SectionCable12);
                if(ParametersName.InSectionCable1) circ.LookupParameter(ParametersName.ParamSectionCable13)?.Set(circuitItem.SectionCable13);
                if (ParametersName.InFactLenCable1) circ.LookupParameter(ParametersName.ParamFactLenCable1)?.Set(circuitItem.FactLenCable1);
                if(ParametersName.InSectionCable2) circ.LookupParameter(ParametersName.ParamSectionCable21)?.Set(circuitItem.SectionCable21);
                if(ParametersName.InSectionCable2) circ.LookupParameter(ParametersName.ParamSectionCable22)?.Set(circuitItem.SectionCable22);
                if(ParametersName.InSectionCable2) circ.LookupParameter(ParametersName.ParamSectionCable23)?.Set(circuitItem.SectionCable23);
                if(ParametersName.InFactLenCable2) circ.LookupParameter(ParametersName.ParamFactLenCable2)?.Set(circuitItem.FactLenCable2);
                if(ParametersName.InLenForCountTKZ) circ.LookupParameter(ParametersName.ParamLenForCountTKZ)?.Set(circuitItem.LenForCountTKZ);
                if(ParametersName.InLenCableCurrent) circ.LookupParameter(ParametersName.ParamLenCableCurrent)?.Set(circuitItem.LenCableCurrent);
                if(ParametersName.InAdmissibleLoss) circ.LookupParameter(ParametersName.ParamAdmissibleLoss)?.Set(circuitItem.AdmissibleLoss);
                if(ParametersName.InCurrentLoss) circ.LookupParameter(ParametersName.ParamCurrentLoss)?.Set(circuitItem.CurrentLoss);
                if(ParametersName.InSetWorkWinterSummer) circ.LookupParameter(ParametersName.ParamSetWorkWinterSummer)?.Set(circuitItem.SetWorkWinterSummer);
                if(ParametersName.InCurrentTKZendLine) circ.LookupParameter(ParametersName.ParamCurrentTKZendLine)?.Set(circuitItem.CurrentTKZendLine);
                if(ParametersName.InCountElements) circ.LookupParameter(ParametersName.ParamCountElements)?.Set(circuitItem.CountElements);
                if(ParametersName.InTypePipe) circ.LookupParameter(ParametersName.ParamTypePipe)?.Set(circuitItem.TypePipe);
                if(ParametersName.InDiameterPipe) circ.LookupParameter(ParametersName.ParamDiameterPipe)?.Set(circuitItem.DiameterPipe);
                if(ParametersName.InLenPipe) circ.LookupParameter(ParametersName.ParamLenPipe)?.Set(circuitItem.LenPipe);
                if(ParametersName.InLenCableInTray ) circ.LookupParameter(ParametersName.ParamLenCableInTray)?.Set(circuitItem.LenCableInTray);
                if(ParametersName.InRoom) circ.LookupParameter(ParametersName.ParamRoom)?.Set(circuitItem.Room);
                if(ParametersName.InTextName) circ.LookupParameter(ParametersName.ParamTextName)?.Set(circuitItem.TextName);
                if(ParametersName.InDoubleName) circ.LookupParameter(ParametersName.ParamDoubleName)?.Set(circuitItem.DoubleName);
                if(ParametersName.InProject) circ.LookupParameter(ParametersName.ParamProject)?.Set(circuitItem.Project);
                if(ParametersName.InFunctional) circ.LookupParameter(ParametersName.ParamFunctional)?.Set(circuitItem.Functional);
            }

           
        }
    }
}
