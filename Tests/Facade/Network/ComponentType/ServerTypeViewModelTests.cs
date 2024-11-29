using Nc.Facade.Network.Components;
using Nc.Facade.Network.ComponentType;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.ComponentType;
[TestClass] public class ServerTypeViewModelTests : SealedNewTests<ServerTypeViewModel, ComponentTypeEntityViewModel> {
    [TestMethod] public void MemoryTest() => PropertyTest("Memory");
    [TestMethod] public void HostnameTest() => PropertyTest("Hostname");

    [TestMethod] public void SwitchesTest() {
        var model = new ServerTypeViewModel();
        var switches = new List<SwitchViewModel> {
            new(),
            new()
        };
        model.Switches = switches;
        Assert.AreEqual(switches, model.Switches);
    }
}
