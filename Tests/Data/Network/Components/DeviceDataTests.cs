using Nc.Data.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Components; 
[TestClass] public class DeviceDataTests : AbstractTests<DeviceData, ComponentData> {
    private class TestClass : DeviceData { }
    protected override DeviceData? CreateObject() => new TestClass();
    [TestMethod] public void GeographicPointIdTest() => PropertyTest();
}
