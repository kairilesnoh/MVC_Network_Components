namespace Nc.Data.Network.Components;
public sealed class SupportStructureData : ComponentData {
    public string? Location { get; set; }
    public DateTime? InstallationDate { get; set; }
    public bool? IsMaintenanceValid { get; set; }
    public int GeographicPointId { get;set; }
}
