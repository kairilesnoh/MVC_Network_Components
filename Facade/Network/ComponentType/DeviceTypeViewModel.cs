using System.ComponentModel;

namespace Nc.Facade.Network.ComponentType;

[Description("Device type")] public sealed class DeviceTypeViewModel : ComponentTypeEntityViewModel {
    [DisplayName("Model")] public string? Model { get; set; }
    [DisplayName("Hardware Version")] public string? HardwareVersion { get; set; }
}
