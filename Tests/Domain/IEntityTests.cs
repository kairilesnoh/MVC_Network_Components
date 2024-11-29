using Nc.Domain;

namespace Nc.Tests.Domain; 
[TestClass] public class IEntityTests : InterfaceTests<IEntity> {
    [TestMethod] public void IdTest() => PropertyTest<int>();
}
