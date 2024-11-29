using Nc.Data.Network.ComponentType;
using Nc.Domain.Network.ComponentType;

namespace Nc.Tests.Domain.Network.ComponentType; 
[TestClass] public class ConnectionComponentTypeTests : ComponentTypeDomainClassTests<ConnectionComponentType, ConnectionComponentTypeData> {
    [TestMethod] public void LocationTest() => ValueTest();
    [TestMethod] public void SpeedTest() => ValueTest();
}
