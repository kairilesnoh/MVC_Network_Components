using Nc.Facade.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Components; 
[TestClass] public class CableWiringViewModelTests : SealedNewTests<CableWiringViewModel, ConnectionComponentViewModel> {
    [TestMethod] public void LengthTest() => PropertyTest("Length");
    [TestMethod] public void ConnectorTypeTest() => PropertyTest("Connector Type");
}
