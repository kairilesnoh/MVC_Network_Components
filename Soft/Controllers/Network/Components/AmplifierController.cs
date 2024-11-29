using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Facade.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.Components; 
public class AmplifierController(IAmplifierRepo repo) : BaseController<Amplifier, AmplifierViewModel>(repo) {
    protected override Amplifier ToModel(AmplifierViewModel viewmodel) =>
        new Amplifier(PropertyCopier.CopyPropertiesFrom<AmplifierViewModel, AmplifierData>(viewmodel));

    protected override async Task<AmplifierViewModel> ToViewAsync(Amplifier model) {
        var viewModel = await base.ToViewAsync(model);
        return viewModel;
    }
}
