using Nc.Data.Network.ComponentType;
using Nc.Domain.Network.ComponentType;

namespace Nc.Tests.Domain.Network.ComponentType; 
[TestClass] public class ServerTypeTests : ComponentTypeDomainClassTests<ServerType, ServerTypeData> {
    [TestMethod] public void MemoryTest() => ValueTest();
    [TestMethod] public void HostnameTest() => ValueTest();
}
