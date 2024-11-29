using Nc.Data.Network.ComponentType;

namespace Nc.Domain.Network.ComponentType;
public sealed class ConnectionComponentType(ConnectionComponentTypeData? data) : ComponentTypeEntity<ConnectionComponentTypeData>(data) {
    public string? Location => _data.Location;
    public double Speed => _data.Speed;
}

