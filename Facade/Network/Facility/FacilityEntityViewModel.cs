using System.ComponentModel;

namespace Nc.Facade.Network.Facility;
[Description("Facility Entity")] public sealed class FacilityEntityViewModel : EntityViewModel {
    [DisplayName("Facility Type Id")] public int FacilityTypeId { get; set; }
}
