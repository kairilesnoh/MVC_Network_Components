using Microsoft.EntityFrameworkCore;
using Nc.Data.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Infra.Network.Components.DbInitializers; 
public sealed class AmplifierDbInitializer(DbContext db, DbSet<AmplifierData> set) : DbInitializer<AmplifierData>(db, set) {
    protected override void SetValues(int index) {
        if (Item == null)
            return;
        Item.Gain = GetRandom.Double(0);
        Item.SerialNum = GetRandomNetwork.GenerateSerialNum();
    }
}
