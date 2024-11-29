using Nc.Data.Network.ComponentType;
using Nc.Domain.Network.ComponentType;
using Nc.Domain.Repos.Network.ComponentType;
using Nc.Infra.Common;

namespace Nc.Infra.Network.ComponentType.Repos;

public class DeviceTypeRepo(NetworkDbContext context) : Repo<DeviceType, DeviceTypeData>(context, context.DeviceTypes), IDeviceTypeRepo {
    protected override IQueryable<DeviceTypeData> AddSearch(IQueryable<DeviceTypeData> sql) {
        return string.IsNullOrEmpty(SearchString) ? sql
            : sql.Where(s => s.HardwareVersion.ToString().Contains(SearchString)
                             || s.Model != null && s.Model.Contains(SearchString));
    }
    protected override DeviceType ToEntity(DeviceTypeData? data) => new DeviceType(data);    
}