using Nc.Data.Network.ComponentType;
using Nc.Domain.Network.ComponentType;

namespace Nc.Tests.Domain.Network.ComponentType;

[TestClass] public class SupportStructureTypeTests : ComponentTypeDomainClassTests<SupportStructureType, SupportStructureTypeData> {
    [TestMethod] public void NameTest() => ValueTest();
    [TestMethod] public void MaterialTest() => ValueTest();
}
