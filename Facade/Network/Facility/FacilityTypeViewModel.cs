using System.ComponentModel;

namespace Nc.Facade.Network.Facility;
[Description("Facility Type")] public sealed class FacilityTypeViewModel: EntityViewModel{
    [DisplayName("Name")] public string? Name { get; set; }
    [DisplayName("Facility Entity")] public List<FacilityEntityViewModel>? FacilityEntities { get; set; }
}
