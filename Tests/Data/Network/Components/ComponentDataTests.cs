using Nc.Data;
using Nc.Data.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Components; 
[TestClass] public class ComponentDataTests : AbstractTests<ComponentData, EntityData> {
    private class TestClass : ComponentData { }
    protected override ComponentData? CreateObject() => new TestClass();
    [TestMethod] public void IdTest() => PropertyTest();
    [TestMethod] public void SerialNumTest() => PropertyTest();
    [TestMethod] public void FacilityIdTest() => PropertyTest();
    [TestMethod] public void NetworkServerTypeIdTest() => PropertyTest();
}

