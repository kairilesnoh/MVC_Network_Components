using Nc.Data.Network.ComponentType;
using Nc.Domain.Network.ComponentType;
using Nc.Domain.Repos.Network.ComponentType;
using Nc.Infra.Common;

namespace Nc.Infra.Network.ComponentType.Repos;
public class ServerTypeRepo(NetworkDbContext context) : Repo<ServerType, ServerTypeData>(context, context.NetworkServerTypes), IServerTypeRepo {
    protected override IQueryable<ServerTypeData> AddSearch(IQueryable<ServerTypeData> sql) {
        return string.IsNullOrEmpty(SearchString) ? sql
            : sql.Where(s => s.Memory.ToString().Contains(SearchString)
                             || s.Hostname != null && s.Hostname.Contains(SearchString));

    }
    protected override ServerType ToEntity(ServerTypeData? data) => new ServerType(data);    
}

