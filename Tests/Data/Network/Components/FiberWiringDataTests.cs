using Nc.Data.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Components; 
[TestClass] public class FiberWiringDataTests : SealedNewTests<FiberWiringData, ConnectionComponentData> {
    [TestMethod] public void LengthTest() => PropertyTest();
    [TestMethod] public void ConnectorTypeTest() => PropertyTest();
}
