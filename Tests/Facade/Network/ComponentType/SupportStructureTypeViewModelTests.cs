using Nc.Facade.Network.ComponentType;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.ComponentType;
[TestClass] public class SupportStructureTypeViewModelTests : SealedNewTests<SupportStructureTypeViewModel, ComponentTypeEntityViewModel> {
    [TestMethod] public void NameTest() => PropertyTest("Name");
    [TestMethod] public void MaterialTest() => PropertyTest("Material");
}
