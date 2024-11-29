using Nc.Data.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Components;
[TestClass] public class RouterDataTests : SealedNewTests<RouterData, ServerData> {
    [TestMethod] public void ModelTest() => PropertyTest();
    [TestMethod] public void IpAddressTest() => PropertyTest();
}
