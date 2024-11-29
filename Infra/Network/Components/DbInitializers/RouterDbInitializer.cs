using Microsoft.EntityFrameworkCore;
using Nc.Data.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Infra.Network.Components.DbInitializers;
public sealed class RouterDbInitializer(DbContext db, DbSet<RouterData> set) : DbInitializer<RouterData>(db, set) {
    protected override void SetValues(int index) {
        if (Item == null) return;
        Item.IpAddress = GetRandomNetwork.IpAddress;
        Item.SerialNum = GetRandomNetwork.GenerateSerialNum();
        Item.Model = GetRandomNetwork.GenerateValueText(typeof(RouterDbInitializer), index, "Model");
        Item.GeographicPointId = GetRandom.Bool() ? GetRandom.Int8(1, 4) : 0;
    }
}


