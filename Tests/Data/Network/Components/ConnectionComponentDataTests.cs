using Nc.Data.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Components; 
[TestClass] public class ConnectionComponentDataTests : AbstractTests<ConnectionComponentData, ComponentData> {
    private class TestClass : ConnectionComponentData { }
    protected override ConnectionComponentData? CreateObject() => new TestClass();
    [TestMethod] public void PathwayIdTest() => PropertyTest();
}
