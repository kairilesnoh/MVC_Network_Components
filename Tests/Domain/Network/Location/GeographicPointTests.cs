using Nc.Data.Network.Location;
using Nc.Domain.Network.Location;

namespace Nc.Tests.Domain.Network.Location; 
[TestClass] public class GeographicPointTests : LocationDomainClassTests<GeographicPoint, GeographicPointData> {
    [TestMethod] public void LatitudeTest() => ValueTest();
    [TestMethod] public void LongitudeTest() => ValueTest();
}
