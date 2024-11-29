using Nc.Data.Network.Components;

namespace Nc.Domain.Network.Components; 
public abstract class ComponentEntity<TData>(TData? data) 
    : Entity<TData>(data) where TData : ComponentData, new() {
    public string? SerialNum => _data.SerialNum;
    public int FacilityId => _data.FacilityId;
}
