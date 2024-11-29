using Nc.Facade.Network.Components;
using System.ComponentModel;

namespace Nc.Facade.Network.ComponentType;

[Description("Network server type")] public sealed class ServerTypeViewModel : ComponentTypeEntityViewModel {
    [DisplayName("Hostname")] public string? Hostname { get; set; }
    [DisplayName("Memory")] public int Memory { get; set; }
    [DisplayName("Switches")] public List<SwitchViewModel>? Switches { get; set; }
}
