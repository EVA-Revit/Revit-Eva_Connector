namespace FromRevitLoader.Services;

using Newtonsoft.Json;
using Revit_Eva_Connector.Items;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

public class JsonService(string titleDocument)
{
    private const string WritePrefix = "EVA_RE_";
    private const string ReadPrefix = "EVA_ER_";

    private readonly string _tempPath = Environment.GetEnvironmentVariable("TMP", EnvironmentVariableTarget.User);

    public void WritePanelItemsToJsonFile(List<PanelItem> panelItems)
    {
        var jsonString = JsonConvert.SerializeObject(panelItems);
        var fileName = $"{WritePrefix + titleDocument}.json";
        var tempFile = Path.Combine(_tempPath, fileName);

        if (File.Exists(tempFile))
        {
            File.Delete(tempFile);
          
        }

        File.WriteAllText(tempFile, jsonString);
    }

    public List<PanelItem> ReadPanelItemsFromJsonFile()
    {
        var fileName = $"{ReadPrefix + titleDocument}.json";
        var tempFile = Path.Combine(_tempPath, fileName);

        if (!File.Exists(tempFile))
        {
            MessageBox.Show("File not found");
            return null;
        }

        var jsonString = File.ReadAllText(tempFile);
        var panelItems = JsonConvert.DeserializeObject<List<PanelItem>>(jsonString);

        return panelItems;
    }
}