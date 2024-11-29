using System.ComponentModel;

namespace Nc.Facade.Network.Components; 
[Description("Device")] public abstract class DeviceViewModel : ComponentEntityViewModel {
    [DisplayName("Geographic Point Id")] public int GeographicPointId { get; set; }
}
