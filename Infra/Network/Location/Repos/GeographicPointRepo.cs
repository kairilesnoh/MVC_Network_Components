using Nc.Data.Network.Location;
using Nc.Domain.Network.Location;
using Nc.Domain.Repos.Network.Location;
using Nc.Infra.Common;

namespace Nc.Infra.Network.Location.Repos;

public class GeographicPointRepo(NetworkDbContext context) : Repo<GeographicPoint, GeographicPointData>(context, context.GeographicPoints), IGeographicPointRepo {
    protected override IQueryable<GeographicPointData> AddSearch(IQueryable<GeographicPointData> sql) {
        return string.IsNullOrEmpty(SearchString) ? sql
            : sql.Where(s => s.Latitude.Contains(SearchString)
                             || s.Longitude.Contains(SearchString));
    }
    protected override GeographicPoint ToEntity(GeographicPointData? data) => new GeographicPoint(data);    
}
