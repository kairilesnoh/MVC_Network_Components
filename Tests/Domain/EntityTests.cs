using Nc.Data.Network.Components;
using Nc.Domain;
using Nc.Helpers.Methods;
using Nc.Tests.Helpers;

namespace Nc.Tests.Domain; 
[TestClass] public class EntityTests : AbstractTests<Entity<RouterData>, object> {
    private class _Entity(RouterData? data) : Entity<RouterData>(data) { }
    private dynamic? _data;
    protected override Entity<RouterData>? CreateObject() {
        _data = GetRandom.Object<RouterData>();
        return new _Entity(_data);
    }
    [TestMethod] public void DataTest() => AreEqualProperties(_data, obj?.Data);
    [TestMethod] public void IdTest() => Assert.AreEqual(_data?.Id, obj?.Id);
}
