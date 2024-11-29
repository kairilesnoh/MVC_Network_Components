using Nc.Data.Network.Facility;
using Nc.Domain.Network.Facility;
using Nc.Domain.Repos.Network.Facility;
using Nc.Facade.Network.Facility;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.Facility;

public class FacilityTypeController(IFacilityTypeRepo repo) : BaseController<FacilityType, FacilityTypeViewModel>(repo) {
    protected override FacilityType ToModel(FacilityTypeViewModel viewmodel) =>
        new FacilityType(PropertyCopier.CopyPropertiesFrom<FacilityTypeViewModel, FacilityTypeData>(viewmodel));
    protected override async Task<FacilityTypeViewModel> ToViewAsync(FacilityType model) {
        if (loadLazy) await model.LoadLazy();
        var viewModel = await base.ToViewAsync(model);
        viewModel.FacilityEntities = model?.FacilityEntities?.Select(PropertyCopier.CopyPropertiesFrom<FacilityEntity, FacilityEntityViewModel>).ToList();
        return viewModel;
    }
}