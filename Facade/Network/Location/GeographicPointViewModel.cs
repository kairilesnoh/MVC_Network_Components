using Nc.Facade.Network.Components;
using System.ComponentModel;

namespace Nc.Facade.Network.Location;
[Description("Geographic Point")] public sealed class GeographicPointViewModel : LocationEntityViewModel {
    [DisplayName("Latitude")] public string Latitude { get; set; } = string.Empty;
    [DisplayName("Longitude")] public string Longitude { get; set; } = string.Empty;
    [DisplayName("Support Structures")] public List<SupportStructureViewModel>? SupportStructures { get; set; }
    [DisplayName("Switches")] public List<SwitchViewModel>? Switches { get; set; }
    [DisplayName("Routers")] public List<RouterViewModel>? Routers { get; set; }
    [DisplayName("Communication Appearances")] public List<CommunicationAppearanceViewModel>? CommunicationAppearances { get; set; }
    [DisplayName("Amplifiers")] public List<AmplifierViewModel>? Amplifiers { get; set; }
    [DisplayName("Filters")] public List<FilterViewModel>? Filters { get; set; }
}
