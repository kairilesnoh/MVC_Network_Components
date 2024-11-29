using Nc.Data.Network.Components;
using Nc.Domain;
using Nc.Domain.Network.Components;
using Nc.Helpers.Methods;
using Nc.Tests.Helpers;

namespace Nc.Tests.Domain.Network.Components; 
[TestClass] public class ComponentEntityTests : AbstractTests<ComponentEntity<CableWiringData>, Entity<CableWiringData>> {
    private class _Entity(CableWiringData? data) : ComponentEntity<CableWiringData>(data) { }
    private dynamic? _data;

    protected override ComponentEntity<CableWiringData>? CreateObject() {
        _data = GetRandom.Object<CableWiringData>();
        return new _Entity(_data);
    }
    [TestMethod] public void DataTest() => AreEqualProperties(_data, obj?.Data);

    [TestMethod] public void IdTest() => Assert.AreEqual(_data?.Id, obj?.Id);

    [TestMethod] public void SerialNumTest() => Assert.AreEqual(_data?.SerialNum, obj?.SerialNum);

    [TestMethod] public void FacilityIdTest() => Assert.AreEqual(_data?.FacilityId, obj?.FacilityId);
}
