using System.ComponentModel;

namespace Nc.Facade.Network.Components;

[Description("Network Server")] public abstract class ServerViewModel : ComponentEntityViewModel {
    [DisplayName("Geographic Point Id")] public int GeographicPointId { get; set; }
}
