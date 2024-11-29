using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Facade.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.Components;
public class SwitchController(ISwitchRepo repo) : BaseController<Switch, SwitchViewModel>(repo) {
    protected override Switch ToModel(SwitchViewModel view) => new(PropertyCopier.CopyPropertiesFrom<SwitchViewModel, SwitchData>(view));
    protected override async Task<SwitchViewModel> ToViewAsync(Switch model) {
        if (loadLazy) await model.LoadLazy();
        var viewModel = await base.ToViewAsync(model);
        return viewModel;
    }
}