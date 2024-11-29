using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nc.Facade.Network.Components;
[Description("Cable Wiring")] public sealed class CableWiringViewModel : ConnectionComponentViewModel {
    private double _length;

    [DisplayName("Length"), Required, Range(0, double.MaxValue, ErrorMessage = "Length needs to be greater than 0.")]
    public double Length {
        get => _length;
        set => _length = Math.Round(value, 2);
    }
    [DisplayName("Connector Type")] public string? ConnectorType { get; set; }
}
