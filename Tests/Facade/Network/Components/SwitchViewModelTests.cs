using Nc.Facade.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Components; 
[TestClass] public class SwitchViewModelTests : SealedNewTests<SwitchViewModel, ServerViewModel> {
    [TestMethod] public void NumberOfPortsTest() => PropertyTest("Number of ports");
    [TestMethod] public void ServerTypeIdTest() => PropertyTest("Server Type Id");
}
