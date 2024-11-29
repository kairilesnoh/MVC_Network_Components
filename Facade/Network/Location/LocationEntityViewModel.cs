using System.ComponentModel;

namespace Nc.Facade.Network.Location;
public abstract class LocationEntityViewModel : EntityViewModel {
    [DisplayName("Description")] public string Description { get; set; } = string.Empty;
}
