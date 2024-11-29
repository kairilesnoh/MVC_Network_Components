using System.ComponentModel;

namespace Nc.Facade.Network.Components;

[Description("Connection Component")] public abstract class ConnectionComponentViewModel : ComponentEntityViewModel {
    [DisplayName("Pathway Id")] public int PathwayId { get; set; }
}
