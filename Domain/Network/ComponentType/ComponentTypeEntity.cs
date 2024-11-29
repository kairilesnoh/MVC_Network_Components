using Nc.Data.Network.ComponentType;

namespace Nc.Domain.Network.ComponentType;
public abstract class ComponentTypeEntity<TData>(TData? data) : Entity<TData>(data) where TData : ComponentTypeData, new() {
    public string Description => _data.Description;
}

