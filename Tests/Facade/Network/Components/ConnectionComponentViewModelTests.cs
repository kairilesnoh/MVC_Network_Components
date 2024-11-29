using Nc.Facade.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Components; 
[TestClass] public class ConnectionComponentViewModelTests : AbstractTests<ConnectionComponentViewModel, ComponentEntityViewModel> {
    private class TestClass : ConnectionComponentViewModel { }
    protected override ConnectionComponentViewModel? CreateObject() => new TestClass();
    [TestMethod] public void PathwayIdTest() => PropertyTest();
}
