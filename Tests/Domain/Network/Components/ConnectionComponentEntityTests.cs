using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Helpers.Methods;
using Nc.Tests.Helpers;

namespace Nc.Tests.Domain.Network.Components; 
[TestClass] public class ConnectionComponentEntityTests : AbstractTests<ConnectionComponentEntity<CableWiringData>, ComponentEntity<CableWiringData>> {
    private class _Entity(CableWiringData? data) : ConnectionComponentEntity<CableWiringData>(data) { }
    private dynamic? _data;

    protected override ConnectionComponentEntity<CableWiringData>? CreateObject() {
        _data = GetRandom.Object<CableWiringData>();
        return new _Entity(_data);
    }
    [TestMethod] public void DataTest() => AreEqualProperties(_data, obj?.Data);
    [TestMethod] public void IdTest() => Assert.AreEqual(_data?.Id, obj?.Id);
    [TestMethod] public void SerialNumTest() => Assert.AreEqual(_data?.SerialNum, obj?.SerialNum);
}
