using Nc.Data.Network.ComponentType;
using Nc.Domain.Network.Components;
using Nc.Domain.Network.ComponentType;
using Nc.Domain.Repos.Network.ComponentType;
using Nc.Facade.Network.Components;
using Nc.Facade.Network.ComponentType;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.ComponentType;

public class ServerTypeController(IServerTypeRepo repo) : BaseController<ServerType, ServerTypeViewModel>(repo) {
    protected override ServerType ToModel(ServerTypeViewModel viewmodel) =>
         new ServerType(PropertyCopier.CopyPropertiesFrom<ServerTypeViewModel, ServerTypeData>(viewmodel));
    protected override async Task<ServerTypeViewModel> ToViewAsync(ServerType model) {
        if (loadLazy) await model.LoadLazy();
        var viewModel = await base.ToViewAsync(model);
        viewModel.Switches = model?.Switches?.Select(PropertyCopier.CopyPropertiesFrom<Switch, SwitchViewModel>).ToList();
        return viewModel;
    }
}