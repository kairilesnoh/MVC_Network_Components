using Nc.Data.Network.Components;

namespace Nc.Domain.Network.Components;
public sealed class Router(RouterData? data) : ServerEntity<RouterData>(data) {
    public string? IpAddress => _data.IpAddress;
    public string? Model => _data.Model;
}




