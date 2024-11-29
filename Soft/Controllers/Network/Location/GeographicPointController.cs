using Nc.Data.Network.Location;
using Nc.Domain.Network.Components;
using Nc.Domain.Network.Location;
using Nc.Domain.Repos.Network.Location;
using Nc.Facade.Network.Components;
using Nc.Facade.Network.Location;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.Location;
public class GeographicPointController(IGeographicPointRepo repo) : BaseController<GeographicPoint, GeographicPointViewModel>(repo) {
    protected override GeographicPoint ToModel(GeographicPointViewModel viewmodel) =>
        new GeographicPoint(PropertyCopier.CopyPropertiesFrom<GeographicPointViewModel, GeographicPointData>(viewmodel));
    
    protected override async Task<GeographicPointViewModel> ToViewAsync(GeographicPoint model) {
        if (loadLazy) await model.LoadLazy();
        var viewModel = await base.ToViewAsync(model);
        viewModel.SupportStructures = model?.SupportStructures?.Select(PropertyCopier.CopyPropertiesFrom<SupportStructure, SupportStructureViewModel>).ToList();
        viewModel.Switches = model?.Switches?.Select(PropertyCopier.CopyPropertiesFrom<Switch, SwitchViewModel>).ToList();
        viewModel.Routers = model?.Routers?.Select(PropertyCopier.CopyPropertiesFrom<Router, RouterViewModel>).ToList();
        viewModel.CommunicationAppearances = model?.CommunicationAppearances?.Select(PropertyCopier.CopyPropertiesFrom<CommunicationAppearance, CommunicationAppearanceViewModel>).ToList();
        viewModel.Switches = model?.Switches?.Select(PropertyCopier.CopyPropertiesFrom<Switch, SwitchViewModel>).ToList();
        viewModel.Amplifiers = model?.Amplifiers?.Select(PropertyCopier.CopyPropertiesFrom<Amplifier, AmplifierViewModel>).ToList();
        viewModel.Filters = model?.Filters?.Select(PropertyCopier.CopyPropertiesFrom<Filter, FilterViewModel>).ToList();
        return viewModel;
    }
}
