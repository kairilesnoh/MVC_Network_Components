using System.ComponentModel;

namespace Nc.Facade.Network.ComponentType;
public abstract class ComponentTypeEntityViewModel : EntityViewModel {
    [DisplayName("Description")] public string Description { get; set; } = string.Empty;
}
