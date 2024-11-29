using System.ComponentModel;

namespace Nc.Facade.Network.Components;
public abstract class ComponentEntityViewModel : EntityViewModel {
    [DisplayName("Serial Number")] public string? SerialNum { get; set; }
    [DisplayName("Facility Id")] public int FacilityId { get; set; }
}