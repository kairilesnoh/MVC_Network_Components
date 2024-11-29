using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Facade.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.Components; 
public class FilterController(IFilterRepo repo) : BaseController<Filter, FilterViewModel>(repo) {
    protected override Filter ToModel(FilterViewModel viewmodel) =>
        new Filter(PropertyCopier.CopyPropertiesFrom<FilterViewModel, FilterData>(viewmodel));

    protected override async Task<FilterViewModel> ToViewAsync(Filter model) {
        var viewModel = await base.ToViewAsync(model);
        return viewModel;
    }
}
