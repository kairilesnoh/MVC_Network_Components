using Microsoft.EntityFrameworkCore;
using Nc.Data.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Infra.Network.Components.DbInitializers;
public sealed class FiberWiringDbInitializer(DbContext db, DbSet<FiberWiringData> set) : DbInitializer<FiberWiringData>(db, set) {
    protected override void SetValues(int index) {
        if (Item == null)
            return;
        Item.Length = GetRandom.Double(0);
        Item.ConnectorType = GetRandomNetwork.ConnectorType;
        Item.SerialNum = GetRandomNetwork.GenerateSerialNum();
        Item.PathwayId = GetRandom.Bool() ? GetRandom.Int8(1,4) : 0;
    }
}
