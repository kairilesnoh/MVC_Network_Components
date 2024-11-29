using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Infra.Common;

namespace Nc.Infra.Network.Components.Repos;

public class CableWiringRepo(NetworkDbContext context) : 
    Repo<CableWiring, CableWiringData>(context, context.CableWirings), ICableWiringRepo {
    protected override IQueryable<CableWiringData> AddSearch(IQueryable<CableWiringData> sql) {
        return string.IsNullOrEmpty(SearchString) ? sql
            : sql.Where(s => s.Length.ToString().Contains(SearchString)
                             || s.SerialNum != null && s.SerialNum.Contains(SearchString)
                             || s.ConnectorType != null && s.ConnectorType.Contains(SearchString));
    }
    protected override CableWiring ToEntity(CableWiringData? data) => new CableWiring(data);
}
