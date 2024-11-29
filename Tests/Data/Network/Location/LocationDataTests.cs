using Nc.Data;
using Nc.Tests.Helpers;
using Nc.Data.Network.Location;

namespace Nc.Tests.Data.Network.Location; 
[TestClass] public class LocationDataTests : AbstractTests<LocationData, EntityData> {
    private class TestClass : LocationData { }
    protected override LocationData? CreateObject() => new TestClass();
    [TestMethod] public void IdTest() => PropertyTest();
    [TestMethod] public void DescriptionTest() => PropertyTest();
}
