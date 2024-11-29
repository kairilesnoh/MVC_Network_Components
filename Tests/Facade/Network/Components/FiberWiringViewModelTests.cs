using Nc.Facade.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Components; 
[TestClass] public class FiberWiringViewModelTests : SealedNewTests<FiberWiringViewModel, ConnectionComponentViewModel> {
    [TestMethod] public void LengthTest() => PropertyTest("Length", true);
    [TestMethod] public void ConnectorTypeTest() => PropertyTest("Connector Type");
}
