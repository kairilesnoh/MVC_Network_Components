using Nc.Data.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Components; 
[TestClass] public class ServerDataTests : AbstractTests<ServerData, ComponentData> {
    private class TestClass : ServerData { }
    protected override ServerData? CreateObject() => new TestClass();
    [TestMethod] public void GeographicPointIdTest() => PropertyTest();
}
