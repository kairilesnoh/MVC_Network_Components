using Nc.Data.Network.ComponentType;

namespace Nc.Domain.Network.ComponentType;
public sealed class SupportStructureType(SupportStructureTypeData? data) : ComponentTypeEntity<SupportStructureTypeData>(data) {
    public string? Name => _data.Name;
    public string? Material => _data.Material;
}
