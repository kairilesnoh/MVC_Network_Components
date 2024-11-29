using Nc.Facade.Network.ComponentType;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.ComponentType;
[TestClass] public class ConnectionComponentTypeViewModelTests : SealedNewTests<ConnectionComponentTypeViewModel, ComponentTypeEntityViewModel> {
    [TestMethod] public void LocationTest() => PropertyTest("Location");
    [TestMethod] public void SpeedTest() => PropertyTest("Speed");
}
