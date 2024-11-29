using Microsoft.EntityFrameworkCore;
using Nc.Data.Network.ComponentType;

namespace Nc.Infra.Network.ComponentType.DbInitializers;

public sealed class DeviceTypeDbInitializer(DbContext db, DbSet<DeviceTypeData> set) : DbInitializer<DeviceTypeData>(db, set) {
    protected override void SetValues(int index) {
        if (Item == null)
            return;
        Item.HardwareVersion = GetRandomNetwork.HardwareVersion;
        Item.Model = GetRandomNetwork.GenerateValueText(typeof(DeviceTypeDbInitializer), index, "Model");
        Item.Description = GetRandomNetwork.GenerateValueText(typeof(DeviceTypeDbInitializer), index, "Description"); 
    }
}
