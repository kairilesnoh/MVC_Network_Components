using Nc.Data.Network.Components;

namespace Nc.Domain.Network.Components; 
public sealed class Amplifier(AmplifierData? data) : DeviceEntity<AmplifierData>(data) {
    public double Gain => _data.Gain;
}
