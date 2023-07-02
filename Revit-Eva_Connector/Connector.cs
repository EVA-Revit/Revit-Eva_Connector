using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revit_Eva_Connector.Items;
using Newtonsoft.Json;
using System.IO;

namespace Revit_Eva_Connector
{
    public class Connector
    {

        public static string MyPath { get; set; }




        public static void SaveToDB(PanelItem panelItem)
        {
            List<PanelItem> allCurrentPanels = ReadAllFromDB();
            allCurrentPanels.Add(panelItem);

            string serializedPanels = JsonConvert.SerializeObject(allCurrentPanels);

            File.WriteAllText(MyPath, serializedPanels);
        }



        public static List<PanelItem> ReadAllFromDB()
        {
            string json = File.ReadAllText(MyPath);

            List<PanelItem> panelItems = JsonConvert.DeserializeObject<List<PanelItem>>(json);

            return panelItems ?? new List<PanelItem>();
        }
    }
}
