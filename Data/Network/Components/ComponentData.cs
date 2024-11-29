namespace Nc.Data.Network.Components;
public abstract class ComponentData : EntityData {
    public string? SerialNum { get; set; }
    public int FacilityId { get; set; }
    public int NetworkServerTypeId { get; set; }
}
