using Microsoft.EntityFrameworkCore;
using Nc.Data.Network.ComponentType;
using Nc.Helpers.Methods;

namespace Nc.Infra.Network.ComponentType.DbInitializers;

public sealed class ConnectionComponentTypeDbInitializer(DbContext db, DbSet<ConnectionComponentTypeData> set) : DbInitializer<ConnectionComponentTypeData>(db, set) {
    protected override void SetValues(int index) {
        if (Item == null)
            return;
        Item.Speed = GetRandom.Double(0);
        Item.Location = GetRandomNetwork.Location;
        Item.Description = GetRandomNetwork.GenerateValueText(typeof(ConnectionComponentTypeDbInitializer), index, "Description");
    }
}
