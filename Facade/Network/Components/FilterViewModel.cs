using System.ComponentModel;

namespace Nc.Facade.Network.Components; 
[Description("Filter")] public sealed class FilterViewModel : DeviceViewModel {
    [DisplayName("Filter Type")] public string? FilterType { get; set; }
}
