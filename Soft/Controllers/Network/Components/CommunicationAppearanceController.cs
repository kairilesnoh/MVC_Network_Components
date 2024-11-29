using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Facade.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.Components;
public class CommunicationAppearanceController(ICommunicationAppearanceRepo repo) : BaseController<CommunicationAppearance, CommunicationAppearanceViewModel>(repo) {
    protected override CommunicationAppearance ToModel(CommunicationAppearanceViewModel viewmodel) =>
        new CommunicationAppearance(PropertyCopier.CopyPropertiesFrom<CommunicationAppearanceViewModel, CommunicationAppearanceData>(viewmodel));
}