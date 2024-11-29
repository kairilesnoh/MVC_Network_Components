using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Infra.Common;

namespace Nc.Infra.Network.Components.Repos;
public class FiberWiringRepo(NetworkDbContext context) : 
    Repo<FiberWiring, FiberWiringData>(context, context.FiberWirings), IFiberWiringRepo {
    protected override IQueryable<FiberWiringData> AddSearch(IQueryable<FiberWiringData> sql) {
        return string.IsNullOrEmpty(SearchString) ? sql
            : sql.Where(s => s.Length.ToString().Contains(SearchString)
                             || s.SerialNum != null && s.SerialNum.Contains(SearchString)
                             || s.ConnectorType != null && s.ConnectorType.Contains(SearchString));
    }
    protected override FiberWiring ToEntity(FiberWiringData? data) => new FiberWiring(data);
}
