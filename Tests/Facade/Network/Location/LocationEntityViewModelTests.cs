using Nc.Facade;
using Nc.Facade.Network.Location;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Location; 
[TestClass] public class LocationEntityViewModelTests : AbstractTests<LocationEntityViewModel, EntityViewModel> {
    private class TestClass : LocationEntityViewModel { }
    protected override LocationEntityViewModel? CreateObject() => new TestClass();
    [TestMethod] public void IdTest() => PropertyTest();
    [TestMethod] public void DescriptionTest() => PropertyTest("Description");
}
