using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Infra.Common;

namespace Nc.Infra.Network.Components.Repos;

public class SwitchesRepo(NetworkDbContext context) : Repo<Switch, SwitchData>(context, context.Switches), ISwitchRepo {
    protected override IQueryable<SwitchData> AddSearch(IQueryable<SwitchData> sql) => string.IsNullOrEmpty(SearchString) ? sql :
        sql.Where(s => s.SerialNum != null && s.SerialNum.Contains(SearchString)
                                                  || s.NumberOfPorts.ToString() != null && s.NumberOfPorts.ToString().Contains(SearchString));
    protected override Switch ToEntity(SwitchData? data) => new Switch(data);
    protected override IQueryable<SwitchData> AddFixedFilter(IQueryable<SwitchData> sql) =>
        (FixedFilter == nameof(SwitchData.NetworkServerTypeId)) 
        ? sql.Where(s => s.NetworkServerTypeId.ToString() == FixedValue)
        : (FixedFilter == nameof(SwitchData.FacilityId)) 
        ? sql.Where(s => s.FacilityId.ToString() == FixedValue)
        : sql;
}
