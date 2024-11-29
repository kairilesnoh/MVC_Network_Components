using Microsoft.EntityFrameworkCore;
using Nc.Data.Network.ComponentType;

namespace Nc.Infra.Network.ComponentType.DbInitializers;

public sealed class SupportStructureTypeDbInitializer(DbContext db, DbSet<SupportStructureTypeData> set) : DbInitializer<SupportStructureTypeData>(db, set) {
    protected override void SetValues(int index) {
        if (Item == null)
            return;
        Item.Name = GetRandomNetwork.GenerateValueText(typeof(SupportStructureTypeDbInitializer), index, "Name");
        Item.Material = GetRandomNetwork.Material;
        Item.Description = GetRandomNetwork.GenerateValueText(typeof(SupportStructureTypeDbInitializer), index, "Description"); 
    }
}

