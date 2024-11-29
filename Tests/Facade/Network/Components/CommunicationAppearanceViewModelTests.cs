using Nc.Facade.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Components; 
[TestClass] public class CommunicationAppearanceViewModelTests : SealedNewTests<CommunicationAppearanceViewModel, ServerViewModel> {
    [TestMethod] public void TypeTest() => PropertyTest("Type");
    [TestMethod] public void IpAddressTest() => PropertyTest("IP address");
}
