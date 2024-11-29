using Nc.Data.Network.Components;

namespace Nc.Domain.Network.Components;
public sealed class MicrowaveComponent(MicrowaveComponentData? data) : ConnectionComponentEntity<MicrowaveComponentData>(data) {
    public double Frequency => _data.Frequency;
    public double PowerOutput => _data.PowerOutput;
}
