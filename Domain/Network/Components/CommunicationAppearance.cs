using Nc.Data.Network.Components;

namespace Nc.Domain.Network.Components;
public sealed class CommunicationAppearance(CommunicationAppearanceData? data) : ServerEntity<CommunicationAppearanceData>(data) {
    public string? IpAddress => _data.IpAddress;
    public string? Type => _data.Type;
}