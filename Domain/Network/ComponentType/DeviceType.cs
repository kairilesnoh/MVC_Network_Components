using Nc.Data.Network.ComponentType;

namespace Nc.Domain.Network.ComponentType;
public sealed class DeviceType(DeviceTypeData? data) : ComponentTypeEntity<DeviceTypeData>(data) {
    public string? Model => _data.Model;
    public string? HardwareVersion => _data.HardwareVersion;
}
