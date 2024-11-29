using Nc.Data.Network.Location;

namespace Nc.Domain.Network.Location;
public abstract class LocationEntity<TData>(TData? data) : Entity<TData>(data) where TData : LocationData, new() {
    public string Description => _data.Description;
}
