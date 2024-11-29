using Nc.Facade;
using Nc.Facade.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Components; 
[TestClass] public class ComponentEntityViewModelTests : AbstractTests<ComponentEntityViewModel, EntityViewModel> {
    private class TestClass : ComponentEntityViewModel { }
    protected override ComponentEntityViewModel? CreateObject() => new TestClass();
    [TestMethod] public void IdTest() => PropertyTest();
    [TestMethod] public void SerialNumTest() => PropertyTest();
    [TestMethod] public void FacilityIdTest() => PropertyTest("Facility Id");
}
