using Microsoft.AspNetCore.Mvc.Rendering;
using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Facade.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.Components;
public class FiberWiringController(IFiberWiringRepo repo) : BaseController<FiberWiring, FiberWiringViewModel>(repo) {
    private static readonly List<string> ConnectorTypes = ["C", "MHV", "SHV", "BNC", "UHF", "Other"];
    protected override FiberWiring ToModel(FiberWiringViewModel viewmodel) =>
        new FiberWiring(PropertyCopier.CopyPropertiesFrom<FiberWiringViewModel, FiberWiringData>(viewmodel));
    
    protected override Task LoadRelatedItems(FiberWiring? model) {
        ViewData["ConnectorTypes"] = new SelectList(ConnectorTypes);
        return Task.CompletedTask;
    }
    protected override async Task<FiberWiringViewModel> ToViewAsync(FiberWiring model) {
        var viewModel = await base.ToViewAsync(model);
        return viewModel;
    }
}
