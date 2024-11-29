using Nc.Facade.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Components; 
[TestClass] public class ServerViewModelTests : AbstractTests<ServerViewModel, ComponentEntityViewModel> {
    private class TestClass : ServerViewModel { }
    protected override ServerViewModel? CreateObject() => new TestClass();
    [TestMethod] public void GeographicPointIdTest() => PropertyTest();
}
