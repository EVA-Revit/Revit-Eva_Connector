namespace FromRevitLoader.Commands;

using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Services;

[Regeneration(RegenerationOption.Manual)]
[Transaction(TransactionMode.Manual)]
public class LoadFromRevitCommand : IExternalCommand
{
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        var document = commandData.Application.ActiveUIDocument.Document;
        var revitService = new RevitService(document);
        var jsonService = new JsonService(document.Title);
        
        revitService.FieldUserConfigs();

        var panels = jsonService.ReadPanelItemsFromJsonFile();

        if (panels == null)
        {
            return Result.Failed;
        }

        revitService.SetPanels(panels);

        return Result.Succeeded;
    }
}