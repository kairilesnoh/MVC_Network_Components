using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Facade.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.Components;
public class SupportStructureController(ISupportStructureRepo repo) : BaseController<SupportStructure, SupportStructureViewModel>(repo) {
    protected override SupportStructure ToModel(SupportStructureViewModel viewmodel) =>
        new SupportStructure(PropertyCopier.CopyPropertiesFrom<SupportStructureViewModel, SupportStructureData>(viewmodel));
}
