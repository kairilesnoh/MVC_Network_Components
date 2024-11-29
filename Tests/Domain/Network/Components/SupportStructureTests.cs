using Nc.Data.Network.Components;
using Nc.Data.Network.Location;
using Nc.Domain.Network.Components;
using Nc.Domain.Network.Location;

namespace Nc.Tests.Domain.Network.Components; 
[TestClass] public class SupportStructureTests : ComponentDomainClassTests<SupportStructure, SupportStructureData> {
    [TestMethod] public void LocationTest() => ValueTest();
    [TestMethod] public void InstallationDateTest() => ValueTest();
    [TestMethod] public void IsMaintenanceValidTest() => ValueTest();
    [TestMethod] public void GeographicPointIdTest() => ValueTest();
    [TestMethod] public void GeographicPointTest() {
        var data1 = new GeographicPointData {
            Latitude = "999",
            Longitude = "84E"
        };
        var data2 = new GeographicPointData {
            Latitude = "u",
            Longitude = "e"
        };
        var geographicPoint = new GeographicPoint(data1);
        Assert.IsNotNull(geographicPoint);
        Assert.AreNotEqual(data1, data2);
    }
}

