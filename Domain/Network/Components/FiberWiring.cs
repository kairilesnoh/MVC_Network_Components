using Nc.Data.Network.Components;

namespace Nc.Domain.Network.Components;
public sealed class FiberWiring(FiberWiringData? data) : ConnectionComponentEntity<FiberWiringData>(data) {
    public double Length => _data.Length;
    public string? ConnectorType => _data.ConnectorType;
}
