using Nc.Data.Network.Facility;
using Nc.Domain.Network.Facility;
using Nc.Domain.Repos.Network.Facility;
using Nc.Facade.Network.Facility;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.Facility;

public class FacilityEntityController(IFacilityEntityRepo repo) : BaseController<FacilityEntity, FacilityEntityViewModel>(repo) {
    protected override FacilityEntity ToModel(FacilityEntityViewModel viewmodel) =>
        new FacilityEntity(PropertyCopier.CopyPropertiesFrom<FacilityEntityViewModel, FacilityData>(viewmodel));
}
