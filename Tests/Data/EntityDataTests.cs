using Nc.Data;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data;
[TestClass] public class EntityDataTests : AbstractTests<EntityData, object> {
    private class TestClass : EntityData { }
    protected override EntityData? CreateObject() => new TestClass();
    [TestMethod] public void IdTest() => PropertyTest();
}