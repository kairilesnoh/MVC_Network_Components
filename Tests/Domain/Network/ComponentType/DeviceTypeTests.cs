using Nc.Data.Network.ComponentType;
using Nc.Domain.Network.ComponentType;

namespace Nc.Tests.Domain.Network.ComponentType; 
[TestClass] public class DeviceTypeTests : ComponentTypeDomainClassTests<DeviceType, DeviceTypeData> {
    [TestMethod] public void ModelTest() => ValueTest();
    [TestMethod] public void HardwareVersionTest() => ValueTest();
}
