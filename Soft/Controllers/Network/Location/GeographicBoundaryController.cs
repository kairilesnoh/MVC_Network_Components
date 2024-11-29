using Nc.Data.Network.Location;
using Nc.Domain.Network.Location;
using Nc.Domain.Repos.Network.Location;
using Nc.Facade.Network.Location;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.Location;
public class GeographicBoundaryController(IGeographicBoundaryRepo repo) : BaseController<GeographicBoundary, GeographicBoundaryViewModel>(repo) {
    protected override GeographicBoundary ToModel(GeographicBoundaryViewModel viewmodel) =>
        new GeographicBoundary(PropertyCopier.CopyPropertiesFrom<GeographicBoundaryViewModel, GeographicBoundaryData>(viewmodel));
}

