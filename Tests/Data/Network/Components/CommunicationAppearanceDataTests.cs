using Nc.Data.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Components;
[TestClass] public class CommunicationAppearanceDataTests : SealedNewTests<CommunicationAppearanceData, ServerData> {
    [TestMethod] public void TypeTest() => PropertyTest();
    [TestMethod] public void IpAddressTest() => PropertyTest();
}
