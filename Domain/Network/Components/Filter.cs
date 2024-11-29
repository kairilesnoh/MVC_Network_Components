using Nc.Data.Network.Components;

namespace Nc.Domain.Network.Components; 
public sealed class Filter(FilterData? data) : DeviceEntity<FilterData>(data) {
    public string? FilterType => _data.FilterType;
}
