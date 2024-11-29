using Nc.Data.Network.ComponentType;
using Nc.Domain;
using Nc.Domain.Network.ComponentType;
using Nc.Helpers.Methods;
using Nc.Tests.Helpers;

namespace Nc.Tests.Domain.Network.ComponentType; 
[TestClass] public class ComponentTypeEntityTests : AbstractTests<ComponentTypeEntity<ServerTypeData>, Entity<ServerTypeData>> {
    private class _Entity(ServerTypeData? data) : ComponentTypeEntity<ServerTypeData>(data) { }
    private dynamic? _data;

    protected override ComponentTypeEntity<ServerTypeData>? CreateObject() {
        _data = GetRandom.Object<ServerTypeData>();
        return new _Entity(_data);
    }
    [TestMethod] public void DataTest() => AreEqualProperties(_data, obj?.Data);
    [TestMethod] public void IdTest() => Assert.AreEqual(_data?.Id, obj?.Id);
    [TestMethod] public void DescriptionTest() => Assert.AreEqual(_data?.Description, obj?.Description);
}
