using Microsoft.EntityFrameworkCore;
using Nc.Data.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Infra.Network.Components.DbInitializers;
public sealed class SupportStructureInitializer(DbContext db, DbSet<SupportStructureData> set) : DbInitializer<SupportStructureData>(db, set) {
    protected override void SetValues(int index) {
        if (Item == null) return;
        Item.Location = GetRandomNetwork.Location;
        Item.InstallationDate = GetRandom.DateTime();
        Item.IsMaintenanceValid = GetRandom.Bool();
        Item.SerialNum = GetRandomNetwork.GenerateSerialNum();
        Item.GeographicPointId = GetRandom.Bool() ? GetRandom.Int8(1, 4) : 0;
    }
}
