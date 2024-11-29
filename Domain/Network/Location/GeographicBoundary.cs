using Nc.Data.Network.Location;

namespace Nc.Domain.Network.Location;
public sealed class GeographicBoundary(GeographicBoundaryData? data) : LocationEntity<GeographicBoundaryData>(data) {
    public string Name => _data.Name;
}
