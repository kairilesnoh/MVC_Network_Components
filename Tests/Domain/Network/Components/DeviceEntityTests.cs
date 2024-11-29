using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Helpers.Methods;
using Nc.Tests.Helpers;

namespace Nc.Tests.Domain.Network.Components; 
[TestClass] public class DeviceEntityTests : AbstractTests<DeviceEntity<AmplifierData>, ComponentEntity<AmplifierData>> {
    private class _Entity(AmplifierData? data) : DeviceEntity<AmplifierData>(data) { }
    private dynamic? _data;

    protected override DeviceEntity<AmplifierData>? CreateObject() {
        _data = GetRandom.Object<AmplifierData>();
        return new _Entity(_data);
    }

    [TestMethod] public void DataTest() => AreEqualProperties(_data, obj?.Data);
    [TestMethod] public void IdTest() => Assert.AreEqual(_data?.Id, obj?.Id);
    [TestMethod] public void SerialNumTest() => Assert.AreEqual(_data?.SerialNum, obj?.SerialNum);
    [TestMethod] public void GeographicPointIdTest() => Assert.AreEqual(_data?.GeographicPointId, obj?.GeographicPointId);
}
