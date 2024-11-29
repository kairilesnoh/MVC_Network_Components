using Nc.Data.Network.ComponentType;
using Nc.Domain.Network.ComponentType;
using Nc.Domain.Repos.Network.ComponentType;
using Nc.Facade.Network.ComponentType;
using Nc.Helpers.Methods;

namespace Nc.Soft.Controllers.Network.ComponentType;

public class DeviceTypeController(IDeviceTypeRepo repo) : BaseController<DeviceType, DeviceTypeViewModel>(repo) {
    protected override DeviceType ToModel(DeviceTypeViewModel viewmodel) => 
        new DeviceType(PropertyCopier.CopyPropertiesFrom<DeviceTypeViewModel, DeviceTypeData>(viewmodel));   
}