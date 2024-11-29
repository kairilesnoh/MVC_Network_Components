using System.ComponentModel;

namespace Nc.Facade.Network.ComponentType;

[Description("Connection component type")] public sealed class ConnectionComponentTypeViewModel : ComponentTypeEntityViewModel {
    private double _speed;
    [DisplayName("Location")] public string? Location { get; set; }
    [DisplayName("Speed")] public double Speed {
        get => _speed;
        set => _speed = Math.Round(value, 2);
    }
}
