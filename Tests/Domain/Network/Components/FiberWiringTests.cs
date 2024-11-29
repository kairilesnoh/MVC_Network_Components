using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;

namespace Nc.Tests.Domain.Network.Components; 
[TestClass] public class FiberWiringTests : ConnectionComponentDomainClassTests<FiberWiring, FiberWiringData> {
    [TestMethod] public void LengthTest() => ValueTest();
    [TestMethod] public void ConnectorTypeTest() => ValueTest();
}
