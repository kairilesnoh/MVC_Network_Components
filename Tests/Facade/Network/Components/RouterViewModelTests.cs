using Nc.Facade.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Components; 
[TestClass] public class RouterViewModelTests : SealedNewTests<RouterViewModel, ServerViewModel> {
    [TestMethod] public void ModelTest() => PropertyTest("Model");
    [TestMethod] public void IpAddressTest() => PropertyTest("IP address");
}
