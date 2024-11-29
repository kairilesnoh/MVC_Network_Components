using Nc.Facade.Network.ComponentType;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.ComponentType;
[TestClass] public class DeviceTypeViewModelTests : SealedNewTests<DeviceTypeViewModel, ComponentTypeEntityViewModel> {
    [TestMethod] public void ModelTest() => PropertyTest("Model");
    [TestMethod] public void HardwareVersionTest() => PropertyTest("Hardware Version");
}
