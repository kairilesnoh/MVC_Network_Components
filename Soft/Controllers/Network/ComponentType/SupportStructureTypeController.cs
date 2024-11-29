using Microsoft.AspNetCore.Mvc.Rendering;
using Nc.Data.Network.ComponentType;
using Nc.Domain.Network.ComponentType;
using Nc.Domain.Repos.Network.ComponentType;
using Nc.Facade.Network.ComponentType;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.ComponentType;
public class SupportStructureTypeController(ISupportStructureTypeRepo repo) : BaseController<SupportStructureType, SupportStructureTypeViewModel>(repo) {
    private static readonly List<string> Materials = ["Steel", "Aluminium", "Concrete", "Wood", "Stainless Steel", "Other"];
    protected override SupportStructureType ToModel(SupportStructureTypeViewModel viewmodel) =>
        new SupportStructureType(PropertyCopier.CopyPropertiesFrom<SupportStructureTypeViewModel, SupportStructureTypeData>(viewmodel));
    
    protected override Task LoadRelatedItems(SupportStructureType? model) {
        ViewData["Materials"] = new SelectList(Materials);
        return Task.CompletedTask;
    }
}
