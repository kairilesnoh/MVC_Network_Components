using Nc.Facade;
using Nc.Facade.Network.ComponentType;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.ComponentType;
[TestClass] public class ComponentTypeEntityViewModelTests : AbstractTests<ComponentTypeEntityViewModel, EntityViewModel> {
    private class TestClass : ComponentTypeEntityViewModel { }
    protected override ComponentTypeEntityViewModel? CreateObject() => new TestClass();
    [TestMethod] public void IdTest() => PropertyTest();
    [TestMethod] public void DescriptionTest() => PropertyTest("Description");
}
