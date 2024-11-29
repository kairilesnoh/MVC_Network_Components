using Microsoft.AspNetCore.Mvc.Rendering;
using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Facade.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.Components;
public class CableWiringController(ICableWiringRepo repo) : BaseController<CableWiring, CableWiringViewModel>(repo) {
    private static readonly List<string> ConnectorTypes = ["C", "MHV", "SHV", "BNC", "UHF", "Other"];
    protected override CableWiring ToModel(CableWiringViewModel viewmodel) => 
        new CableWiring(PropertyCopier.CopyPropertiesFrom<CableWiringViewModel, CableWiringData>(viewmodel));
    
    protected override Task LoadRelatedItems(CableWiring? model) {
        ViewData["ConnectorTypes"] = new SelectList(ConnectorTypes);
        return Task.CompletedTask;
    }
    protected override async Task<CableWiringViewModel> ToViewAsync(CableWiring model) {
        var viewModel = await base.ToViewAsync(model);
        return viewModel;
    }
}
