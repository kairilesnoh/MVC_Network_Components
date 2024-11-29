using Microsoft.EntityFrameworkCore;
using Nc.Data.Network.Components;

namespace Nc.Infra.Network.Components.DbInitializers; 
public sealed class FilterDbInitializer(DbContext db, DbSet<FilterData> set) : DbInitializer<FilterData>(db, set) {
    protected override void SetValues(int index) {
        if (Item == null)
            return;
        Item.FilterType = GetRandomNetwork.GenerateValueText(typeof(FilterDbInitializer), index, "Type");
        Item.SerialNum = GetRandomNetwork.GenerateSerialNum();
    }
}
