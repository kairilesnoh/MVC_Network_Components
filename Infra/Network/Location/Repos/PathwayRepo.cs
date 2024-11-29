using Nc.Data.Network.Location;
using Nc.Domain.Network.Location;
using Nc.Domain.Repos.Network.Location;
using Nc.Infra.Common;

namespace Nc.Infra.Network.Location.Repos;

public class PathwayRepo(NetworkDbContext context) : Repo<Pathway, PathwayData>(context, context.Pathways), IPathwayRepo {
    protected override IQueryable<PathwayData> AddSearch(IQueryable<PathwayData> sql) {
        return string.IsNullOrEmpty(SearchString) ? sql
            : sql.Where(s => s.TotalDistance.ToString().Contains(SearchString)
            || s.Description.Contains(SearchString));
    }
    protected override Pathway ToEntity(PathwayData? data) => new Pathway(data); 
}
