namespace FromRevitLoader.Commands;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using Services;

[Regeneration(RegenerationOption.Manual)]
[Transaction(TransactionMode.Manual)]
public class UnLoadFromRevitCommand : IExternalCommand
{
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        var document = commandData.Application.ActiveUIDocument.Document;
        var revitService = new RevitService(document);
        revitService.FieldUserConfigs();
        var panels = revitService.GetPanels();

        var jsonService = new JsonService(document.Title);
        jsonService.WritePanelItemsToJsonFile(panels);

        return Result.Succeeded;
    }
}