using Nc.Data.Network.Components;

namespace Nc.Domain.Network.Components;
public sealed class CableWiring(CableWiringData? data) : ConnectionComponentEntity<CableWiringData>(data) {
    public double Length => _data.Length;
    public string? ConnectorType => _data.ConnectorType;
}
