using Microsoft.EntityFrameworkCore;
using Nc.Data.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Infra.Network.Components.DbInitializers;
public sealed class MicrowaveComponentInitializer(DbContext db, DbSet<MicrowaveComponentData> set) : DbInitializer<MicrowaveComponentData>(db, set) {
    protected override void SetValues(int index) {
        if (Item == null)
            return;
        Item.Frequency = GetRandom.Double(0);
        Item.SerialNum = GetRandomNetwork.GenerateSerialNum();
        Item.PowerOutput = GetRandom.Double(0);
        Item.PathwayId = GetRandom.Bool() ? GetRandom.Int8(1, 4) : 0;
    }
}
