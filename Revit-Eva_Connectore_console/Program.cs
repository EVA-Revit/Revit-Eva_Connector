#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revit_Eva_Connector.Items;
using Newtonsoft.Json;
using Revit_Eva_Connector;

namespace Revit_Eva_Connector_console
{
    internal class Program
    {





        static string? MyPath { get; set; }
        static void Main(string[] args)
        {













            //bool isWork = true;

            string path = "EVA_connector.json";

            var mpath = Path.GetTempPath();

            MyPath = mpath + path;
            //if (File.Exists(MyPath) == false)
            //{
            //    var file = File.Create(MyPath);
            //    file.Close();


            //}

            //MyPath = "null";
            if (MyPath != null) Console.WriteLine(MyPath);
            Console.WriteLine(mpath);

            ConnectorJson.MyPath = MyPath;
            var temp = ConnectorJson.ReadAllFromDB();

            var pop = temp.First().Id.ToString();
            Console.WriteLine(pop);
            Console.ReadLine();

            //string allComands = "0 - Вывести всех \n 1 - Добавить нового \n 2 - удалить  \n 3 - выход";

            //while (isWork)
            //{
            //    Console.WriteLine(allComands);

            //    string inputComandStr = Console.ReadLine();
            //    int inputComand = 0;

            //    try
            //    {
            //        inputComand = int.Parse(inputComandStr);
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Нет такой команды");
            //    }

            //    switch (inputComand)
            //    {
            //        case 0:
            //            {
            //                var AllPanels = ReadAllFromDB();
            //                if (AllPanels.Count == 0) Console.WriteLine("Пусто");
            //                foreach (var Panel in AllPanels)
            //                {
            //                    Console.WriteLine(Panel);
            //                }
            //                break;
            //            }

            //        case 1:
            //            {
            //                Console.WriteLine("Ввудите имя");
            //                string name = Console.ReadLine();

            //                PanelItem panel = new PanelItem();
            //                panel.Name = name;
            //                SaveToDB(panel);

            //                Console.WriteLine("Успешно");
            //                break;
            //            }
            //        case 2:
            //            {
            //                Console.WriteLine("Введите имя");
            //                string namePanel = Console.ReadLine();

            //                int name = GetIntFromString(namePanel);
            //                if (name == 0)
            //                {
            //                    Console.WriteLine("Нет такого");
            //                }
            //                else
            //                {
            //                    bool result = DeleteFromDB(name);
            //                    if (result)
            //                    {
            //                        Console.WriteLine("Успешно");
            //                    }
            //                    else Console.WriteLine("Ошибка");
            //                }
            //                break;
            //            }
            //        case 3:
            //            {
            //                isWork = false;
            //                Console.WriteLine("Пока");
            //                break;
            //            }
            //        default:
            //            {
            //                Console.WriteLine("Нет такой команды");
            //                break;
            //            }
            //    }


            //}

        }

        static int GetIntFromString(string str)
        {
            int inputComand = 0;

            try
            {
                inputComand = int.Parse(str);
            }
            catch (FormatException)
            {
                Console.WriteLine("Нет такой команды");
            }

            return inputComand;
        }
        static void SaveToDB(PanelItem panelItem)
        {
            List<PanelItem> allCurrentPanels = ReadAllFromDB();
            allCurrentPanels.Add(panelItem);

            string serializedPanels = JsonConvert.SerializeObject(allCurrentPanels);

            File.WriteAllText(MyPath, serializedPanels);
        }
        static void SaveToDB(List<PanelItem> panels)
        {
            string serializedPanels = JsonConvert.SerializeObject(panels);

            File.WriteAllText(MyPath, serializedPanels);
        }

        static bool DeleteFromDB(int id)
        {
            List<PanelItem> AllCurrentPanels = ReadAllFromDB();

            PanelItem panelForDeletion = AllCurrentPanels.FirstOrDefault(u => u.Id == id);

            bool result = false;
            if (panelForDeletion != null)
            {
                AllCurrentPanels.Remove(panelForDeletion);
                SaveToDB(AllCurrentPanels);
                result = true;
            }
            return result;
        }

        static List<PanelItem> ReadAllFromDB()
        {
            string json = File.ReadAllText(MyPath);
#nullable disable
            List<PanelItem> panelItems = JsonConvert.DeserializeObject<List<PanelItem>>(json);
#nullable enable
            return panelItems ?? new List<PanelItem>();
        }





    }
}
