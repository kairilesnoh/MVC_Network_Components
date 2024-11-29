using Microsoft.EntityFrameworkCore;
using Nc.Data.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Infra.Network.Components.DbInitializers;
public sealed class CommunicationAppearanceDbInitializer(DbContext db, DbSet<CommunicationAppearanceData> set) : DbInitializer<CommunicationAppearanceData>(db, set) {
    protected override void SetValues(int index) {
        if (Item == null) return;
        Item.IpAddress = GetRandomNetwork.IpAddress;
        Item.SerialNum = GetRandomNetwork.GenerateSerialNum();
        Item.Type = GetRandomNetwork.GenerateValueText(typeof(CommunicationAppearanceDbInitializer), index, "Type");
        Item.GeographicPointId = GetRandom.Bool() ? GetRandom.Int8(1, 4) : 0;
    }
}
