using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;

namespace Nc.Tests.Domain.Network.Components; 
[TestClass] public class RouterTests : NetworkServerDomainClassTests<Router, RouterData> {
    [TestMethod] public void ModelTest() => ValueTest();
    [TestMethod] public void IpAddressTest() => ValueTest();
}
