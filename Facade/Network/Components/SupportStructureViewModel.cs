using System.ComponentModel;

namespace Nc.Facade.Network.Components;

[Description("Network Support Structure")] public sealed class SupportStructureViewModel : ComponentEntityViewModel {
    [DisplayName("Location")] public string? Location { get; set; }
    [DisplayName("Installation Date")] public DateTime? InstallationDate { get; set; }
    [DisplayName("Valid Maintenance")] public bool? IsMaintenanceValid { get; set; }
    [DisplayName("Geographic Point Id")] public int GeographicPointId { get; set; }
}
