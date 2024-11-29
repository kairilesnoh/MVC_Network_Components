using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;

namespace Nc.Tests.Domain.Network.Components;
[TestClass] public class SwitchTests : NetworkServerDomainClassTests<Switch, SwitchData> {
    [TestMethod] public void SerialNumberTest() => ValueTest();
    [TestMethod] public void NumberOfPortsTest() => ValueTest();
}
