using Microsoft.EntityFrameworkCore;
using Nc.Data.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Infra.Network.Components.DbInitializers;
public sealed class SwitchDbInitializer(DbContext db, DbSet<SwitchData> set) : DbInitializer<SwitchData>(db, set) {
    protected override void SetValues(int index) {
        if (Item == null) return;
        Item.SerialNum = GetRandomNetwork.GenerateSerialNum();
        Item.NumberOfPorts = GetRandom.UInt8(2, 24);
        Item.GeographicPointId = GetRandom.Bool() ? GetRandom.Int8(1, 4) : 0;
    }
}
