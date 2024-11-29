using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;

namespace Nc.Tests.Domain.Network.Components; 
[TestClass] public class CommunicationAppearanceTests : NetworkServerDomainClassTests<CommunicationAppearance, CommunicationAppearanceData> {
    [TestMethod] public void TypeTest() => ValueTest();
    [TestMethod] public void IpAddressTest() => ValueTest();
}
