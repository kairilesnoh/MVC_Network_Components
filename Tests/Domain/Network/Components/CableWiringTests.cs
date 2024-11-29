using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;

namespace Nc.Tests.Domain.Network.Components; 
[TestClass] public class CableWiringTests : ConnectionComponentDomainClassTests<CableWiring, CableWiringData> {
    [TestMethod] public void LengthTest() => ValueTest();
    [TestMethod] public void ConnectorTypeTest() => ValueTest();
}
