using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Facade.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.Components;
public class MicrowaveComponentController(IMicrowaveComponentRepo repo) : BaseController<MicrowaveComponent, MicrowaveComponentViewModel>(repo) {
    protected override MicrowaveComponent ToModel(MicrowaveComponentViewModel viewmodel) =>
        new MicrowaveComponent(PropertyCopier.CopyPropertiesFrom<MicrowaveComponentViewModel, MicrowaveComponentData>(viewmodel));
}
