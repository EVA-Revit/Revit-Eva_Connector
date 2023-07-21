using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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

            MainViewModel parametersName;

            if (paramSettings != null && paramSettings.StorageInProject) parametersName = new MainViewModel(paramSettings);
            else
            {
                INIManager manager = new INIManager("C:\\ProgramData\\Autodesk\\Revit\\Addins\\2022\\EVA_Settings.ini");
                parametersName = new MainViewModel();


                ReadAndWriteUserParameters.ReadFromIniUserParametrs(manager, parametersName);
            }




            //В зависимости от настроек произвести сбор данных с ревит 
            //Получение всех панелей
            FilteredElementCollector allBoards = new FilteredElementCollector(doc)
                           .OfCategory(BuiltInCategory.OST_ElectricalEquipment).WhereElementIsNotElementType();

            foreach (var board in allBoards)
            {
                //var fullCircuits = board.MEPModel.GetElectricalSystems(); //Получение всех цепей щита
            }





            //TaskDialog.Show("New plagin", parametersName.ParamCountElements);

            return true;
        }
        public static Element GetStorageElement()
        {
            ProjectInfo pi = doc.ProjectInformation;
            return pi as Element;
        }
    }
}
