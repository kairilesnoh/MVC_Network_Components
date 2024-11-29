using Nc.Data.Network.ComponentType;
using Nc.Domain.Network.ComponentType;
using Nc.Domain.Repos.Network.ComponentType;
using Nc.Infra.Common;

namespace Nc.Infra.Network.ComponentType.Repos;
public class ConnectionComponentTypeRepo(NetworkDbContext context) : Repo<ConnectionComponentType, ConnectionComponentTypeData>(context, context.ConnectionComponentTypes), IConnectionComponentTypeRepo {
    protected override IQueryable<ConnectionComponentTypeData> AddSearch(IQueryable<ConnectionComponentTypeData> sql) {
        return string.IsNullOrEmpty(SearchString) ? sql
            : sql.Where(s => s.Speed.ToString().Contains(SearchString)
                             || s.Location != null && s.Location.Contains(SearchString));
    }
    protected override ConnectionComponentType ToEntity(ConnectionComponentTypeData? data) => new ConnectionComponentType(data);    
}
