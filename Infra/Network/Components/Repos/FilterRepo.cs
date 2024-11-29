using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Infra.Common;

namespace Nc.Infra.Network.Components.Repos; 
public class FilterRepo(NetworkDbContext context) :
    Repo<Filter, FilterData>(context, context.Filters), IFilterRepo {
    protected override IQueryable<FilterData> AddSearch(IQueryable<FilterData> sql) {
        return string.IsNullOrEmpty(SearchString) ? sql
            : sql.Where(s => s.SerialNum != null && s.SerialNum.Contains(SearchString)
                             || s.FilterType != null && s.FilterType.Contains(SearchString));
    }
    protected override Filter ToEntity(FilterData? data) => new Filter(data);
}
