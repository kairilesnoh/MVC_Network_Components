using Nc.Data.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Components; 
[TestClass] public class SwitchDataTests : SealedNewTests<SwitchData, ServerData> {
    [TestMethod] public void NumberOfPortsTest() => PropertyTest();
    [TestMethod] public void ServerTypeIdTest() => PropertyTest();
}
