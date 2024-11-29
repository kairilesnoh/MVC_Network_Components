using System.ComponentModel;

namespace Nc.Facade.Network.Components;
[Description("Switch")] public sealed class SwitchViewModel : ServerViewModel{
    [DisplayName("Number of ports")] public int NumberOfPorts { get; set; }
    [DisplayName("Server Type Id")] public int ServerTypeId { get; set; }
}
