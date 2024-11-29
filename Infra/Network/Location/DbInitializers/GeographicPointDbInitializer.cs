using Microsoft.EntityFrameworkCore;
using Nc.Data.Network.Location;

namespace Nc.Infra.Network.Location.DbInitializers;
public sealed class GeographicPointDbInitializer(DbContext db, DbSet<GeographicPointData> set) : DbInitializer<GeographicPointData>(db, set) {
    protected override void SetValues(int index) {
        if (Item == null) return;
        Item.Latitude = GetRandomNetwork.Latitude;
        Item.Longitude = GetRandomNetwork.Longitude;
        Item.Description = GetRandomNetwork.GenerateValueText(typeof(GeographicPointDbInitializer), index, "Description");
    }
}
