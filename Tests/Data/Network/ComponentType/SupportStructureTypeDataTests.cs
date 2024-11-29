using Nc.Data.Network.ComponentType;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.ComponentType;
[TestClass] public class SupportStructureTypeDataTests : SealedNewTests<SupportStructureTypeData, ComponentTypeData> {
    [TestMethod] public void NameTest() => PropertyTest();
    [TestMethod] public void MaterialTest() => PropertyTest();
}
