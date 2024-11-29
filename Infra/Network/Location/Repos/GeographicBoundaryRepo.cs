using Nc.Data.Network.Location;
using Nc.Domain.Network.Location;
using Nc.Domain.Repos.Network.Location;
using Nc.Infra.Common;

namespace Nc.Infra.Network.Location.Repos;

public class GeographicBoundaryRepo(NetworkDbContext context) : Repo<GeographicBoundary, GeographicBoundaryData>(context, context.GeographicBoundaries), IGeographicBoundaryRepo {
    protected override IQueryable<GeographicBoundaryData> AddSearch(IQueryable<GeographicBoundaryData> sql) {
        return string.IsNullOrEmpty(SearchString) ? sql
            : sql.Where(s => s.Name != null && s.Name.Contains(SearchString)
                             || s.Description != null && s.Description.Contains(SearchString));
    }
    protected override GeographicBoundary ToEntity(GeographicBoundaryData? data) => new GeographicBoundary(data);   
}
