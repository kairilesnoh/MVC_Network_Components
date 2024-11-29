using Nc.Data.Network.Location;
using Nc.Domain.Network.Components;
using Nc.Domain.Network.Location;
using Nc.Domain.Repos.Network.Location;
using Nc.Facade.Network.Components;
using Nc.Facade.Network.Location;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.Location;
public class PathwayController(IPathwayRepo repo) : BaseController<Pathway, PathwayViewModel>(repo) {
    protected override Pathway ToModel(PathwayViewModel viewmodel) =>
         new Pathway(PropertyCopier.CopyPropertiesFrom<PathwayViewModel, PathwayData>(viewmodel));
    
    protected override async Task<PathwayViewModel> ToViewAsync(Pathway model) {
        if (loadLazy) await model.LoadLazy();
        var viewModel = await base.ToViewAsync(model);
        viewModel.CableWirings = model?.CableWirings?.Select(PropertyCopier.CopyPropertiesFrom<CableWiring, CableWiringViewModel>).ToList();
        viewModel.FiberWirings = model?.FiberWirings?.Select(PropertyCopier.CopyPropertiesFrom<FiberWiring, FiberWiringViewModel>).ToList();
        viewModel.MicrowaveComponents = model?.MicrowaveComponents?.Select(PropertyCopier.CopyPropertiesFrom<MicrowaveComponent, MicrowaveComponentViewModel>).ToList();
        return viewModel;
    }
}
