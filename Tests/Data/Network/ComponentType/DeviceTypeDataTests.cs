using Nc.Data.Network.ComponentType;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.ComponentType;
[TestClass] public class DeviceTypeDataTests : SealedNewTests<DeviceTypeData, ComponentTypeData> {
    [TestMethod] public void ModelTest() => PropertyTest();
    [TestMethod] public void HardwareVersionTest() => PropertyTest();
}
