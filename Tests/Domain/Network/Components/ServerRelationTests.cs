using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Helpers.Methods;
using Nc.Tests.Helpers;

namespace Nc.Tests.Domain.Network.Components; 
[TestClass] public class ServerRelationTests : AbstractTests<ServerEntity<RouterData>, ComponentEntity<RouterData>> {
    private class _Entity(RouterData? data) : ServerEntity<RouterData>(data) { }
    private dynamic? _data;

    protected override ServerEntity<RouterData>? CreateObject() {
        _data = GetRandom.Object<RouterData>();
        return new _Entity(_data);
    }
    [TestMethod] public void DataTest() => AreEqualProperties(_data, obj?.Data);
    [TestMethod] public void IdTest() => Assert.AreEqual(_data?.Id, obj?.Id);
    [TestMethod] public void GeographicPointIdTest() => Assert.AreEqual(_data?.Id, obj?.Id);
}
