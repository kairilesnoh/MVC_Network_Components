using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Infra.Common;

namespace Nc.Infra.Network.Components.Repos;

public class RoutersRepo(NetworkDbContext context) : Repo<Router, RouterData>(context, context.Routers), IRouterRepo {
    protected override IQueryable<RouterData> AddSearch(IQueryable<RouterData> sql) => string.IsNullOrEmpty(SearchString) ? sql :
        sql.Where(s => s.IpAddress != null && (s.IpAddress.Contains(SearchString)
                                               || s.Model != null && s.Model.Contains(SearchString)));
    protected override Router ToEntity(RouterData? data) => new Router(data);
}