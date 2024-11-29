using System.ComponentModel;

namespace Nc.Facade.Network.Components;
[Description("Communication Appearance")] public sealed class CommunicationAppearanceViewModel : ServerViewModel{
    [DisplayName("Type")] public string? Type { get; set; }
    [DisplayName("IP address")] public string? IpAddress { get; set; }
}
