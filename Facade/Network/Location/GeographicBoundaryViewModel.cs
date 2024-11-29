using System.ComponentModel;

namespace Nc.Facade.Network.Location;
[Description("Geographic Boundary")] public sealed class GeographicBoundaryViewModel : LocationEntityViewModel {
    [DisplayName("Boundary Name")] public string Name { get; set; } = string.Empty;
}
