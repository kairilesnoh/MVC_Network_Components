using Nc.Domain;
using Nc.Helpers.Methods;
using Nc.Tests.Helpers;
using Nc.Domain.Network.Location;
using Nc.Data.Network.Location;

namespace Nc.Tests.Domain.Network.Location; 
[TestClass] public class LocationEntityTests : AbstractTests<LocationEntity<PathwayData>, Entity<PathwayData>> {
    private class _Entity(PathwayData? data) : LocationEntity<PathwayData>(data) { }
    private dynamic? _data;

    protected override LocationEntity<PathwayData>? CreateObject() {
        _data = GetRandom.Object<PathwayData>();
        return new _Entity(_data);
    }
    [TestMethod] public void DataTest() => AreEqualProperties(_data, obj?.Data);
    [TestMethod] public void IdTest() => Assert.AreEqual(_data?.Id, obj?.Id);
    [TestMethod] public void DescriptionTest() => Assert.AreEqual(_data?.Description, obj?.Description);
}
