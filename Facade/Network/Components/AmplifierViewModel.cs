using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Nc.Facade.Network.Components; 
[Description("Amplifier")] public sealed class AmplifierViewModel : DeviceViewModel {
    private double _gain;

    [DisplayName("Gain"), Required, Range(0, double.MaxValue, ErrorMessage = "Gain needs to be greater than 0.")]
    public double Gain {
        get => _gain;
        set => _gain = Math.Round(value, 2);
    }
}
