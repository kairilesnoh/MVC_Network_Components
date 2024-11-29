using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Facade.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.Components;
public class RouterController(IRouterRepo repo) : BaseController<Router, RouterViewModel>(repo) {
    protected override Router ToModel(RouterViewModel viewmodel) =>
        new Router(PropertyCopier.CopyPropertiesFrom<RouterViewModel, RouterData>(viewmodel));    
}