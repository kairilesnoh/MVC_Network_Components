using System.ComponentModel;

namespace Nc.Facade.Network.Components;
[Description("Router")] public sealed class RouterViewModel : ServerViewModel {
    [DisplayName("Model")] public string? Model { get; set; }
    [DisplayName("IP address")] public string? IpAddress { get; set; }
}
