using Nc.Data;
using Nc.Data.Network.ComponentType;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.ComponentType; 
[TestClass] public class ComponentTypeDataTests : AbstractTests<ComponentTypeData, EntityData> {
    private class TestClass : ComponentTypeData { }
    protected override ComponentTypeData? CreateObject() => new TestClass();
    [TestMethod] public void IdTest() => PropertyTest();
    [TestMethod] public void DescriptionTest() => PropertyTest();
}
