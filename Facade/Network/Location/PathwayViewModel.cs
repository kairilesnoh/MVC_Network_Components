using Nc.Facade.Network.Components;
using System.ComponentModel;

namespace Nc.Facade.Network.Location;
[Description("Pathway")] public sealed class PathwayViewModel : LocationEntityViewModel {
    private double _totalDistance;
    [DisplayName("Total Distance")] public double TotalDistance {
        get => _totalDistance;
        set => _totalDistance = Math.Round(value, 2);
    }
    [DisplayName("Cable Wirings")] public List<CableWiringViewModel>? CableWirings { get; set; }
    [DisplayName("Fiber Wirings")] public List<FiberWiringViewModel>? FiberWirings { get; set; }
    [DisplayName("Microwave Components")] public List<MicrowaveComponentViewModel>? MicrowaveComponents { get; set; }
}
