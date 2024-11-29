using Nc.Data.Network.ComponentType;
using Nc.Domain.Network.ComponentType;
using Nc.Domain.Repos.Network.ComponentType;
using Nc.Infra.Common;

namespace Nc.Infra.Network.ComponentType.Repos;
public class SupportStructureTypeRepo(NetworkDbContext context) : Repo<SupportStructureType, SupportStructureTypeData>(context, context.SupportStructureTypes), ISupportStructureTypeRepo {
    protected override IQueryable<SupportStructureTypeData> AddSearch(IQueryable<SupportStructureTypeData> sql) {
        return string.IsNullOrEmpty(SearchString) ? sql
            : sql.Where(s => s.Name != null && s.Name.Contains(SearchString)
                             || s.Material != null && s.Material.Contains(SearchString));
    }
    protected override SupportStructureType ToEntity(SupportStructureTypeData? data) => new SupportStructureType(data);    
}
