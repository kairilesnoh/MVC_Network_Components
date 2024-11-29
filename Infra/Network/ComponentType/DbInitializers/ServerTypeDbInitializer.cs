using Microsoft.EntityFrameworkCore;
using Nc.Data.Network.ComponentType;
using Nc.Helpers.Methods;

namespace Nc.Infra.Network.ComponentType.DbInitializers;

public sealed class ServerTypeDbInitializer(DbContext db, DbSet<ServerTypeData> set) : DbInitializer<ServerTypeData>(db, set) {
    protected override void SetValues(int index) {
        if (Item == null)
            return;
        Item.Hostname = GetRandomNetwork.GenerateValueText(typeof(ServerTypeDbInitializer), index, "Hostname");
        Item.Memory = GetRandom.UInt16();
        Item.Description = GetRandomNetwork.GenerateValueText(typeof(ServerTypeDbInitializer), index, "Description");
    }
}

