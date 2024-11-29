using System.ComponentModel;

namespace Nc.Facade.Network.ComponentType;
[Description("Support structure type")] public sealed class SupportStructureTypeViewModel : ComponentTypeEntityViewModel {
    [DisplayName("Name")] public string? Name { get; set; }
    [DisplayName("Material")] public string? Material { get; set; }
}
