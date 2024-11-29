using Nc.Data.Network.ComponentType;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.ComponentType;
[TestClass] public class ServerTypeDataTests : SealedNewTests<ServerTypeData, ComponentTypeData> {
    [TestMethod] public void MemoryTest() => PropertyTest();
    [TestMethod] public void HostnameTest() => PropertyTest();
}
