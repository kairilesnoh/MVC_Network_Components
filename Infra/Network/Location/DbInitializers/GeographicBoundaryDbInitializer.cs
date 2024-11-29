using Microsoft.EntityFrameworkCore;
using Nc.Data.Network.Location;

namespace Nc.Infra.Network.Location.DbInitializers;
public sealed class GeographicBoundaryDbInitializer(DbContext db, DbSet<GeographicBoundaryData> set) : DbInitializer<GeographicBoundaryData>(db, set) {
    protected override void SetValues(int index) {
        if (Item == null) return;
        Item.Name = GetRandomNetwork.GenerateValueText(typeof(GeographicBoundaryDbInitializer), index, "Name");
        Item.Description = GetRandomNetwork.GenerateValueText(typeof(GeographicBoundaryDbInitializer), index, "Description");
    }
}
