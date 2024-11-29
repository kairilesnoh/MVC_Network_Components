using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nc.Facade.Network.Components;
[Description("Microwave Component")] public sealed class MicrowaveComponentViewModel : ConnectionComponentViewModel {
    private double _frequency;
    private double _powerOutput;

    [DisplayName("Frequency"), Required, Range(0, double.MaxValue, ErrorMessage = "Frequency needs to be greater than 0.")]
    public double Frequency {
        get => _frequency;
        set => _frequency = Math.Round(value, 2);
    }

    [DisplayName("Power Output"), Required, Range(0, double.MaxValue, ErrorMessage = "Power output needs to be greater than 0.")]
    public double PowerOutput {
        get => _powerOutput;
        set => _powerOutput = Math.Round(value, 2);
    }
}

