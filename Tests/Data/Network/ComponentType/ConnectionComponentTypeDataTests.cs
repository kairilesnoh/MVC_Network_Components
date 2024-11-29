using Nc.Data.Network.ComponentType;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.ComponentType;
[TestClass] public class ConnectionComponentTypeDataTests : SealedNewTests<ConnectionComponentTypeData, ComponentTypeData> {
    [TestMethod] public void LocationTest() => PropertyTest();
    [TestMethod] public void SpeedTest() => PropertyTest();
}
