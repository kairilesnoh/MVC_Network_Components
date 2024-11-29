using Microsoft.EntityFrameworkCore;
using Nc.Data.Network.Location;
using Nc.Helpers.Methods;

namespace Nc.Infra.Network.Location.DbInitializers;
public sealed class PathwayDbInitializer(DbContext db, DbSet<PathwayData> set) : DbInitializer<PathwayData>(db, set) {
    protected override void SetValues(int index) {
        if (Item == null) return;
        Item.TotalDistance = GetRandom.Double(0);
        Item.Description = GetRandomNetwork.GenerateValueText(typeof(PathwayDbInitializer), index, "Description");
    }
}
