using Nc.Data.Network.Location;
using Nc.Domain.Network.Location;

namespace Nc.Tests.Domain.Network.Location; 
[TestClass] public class GeographicBoundaryTests : LocationDomainClassTests<GeographicBoundary, GeographicBoundaryData> {
    [TestMethod] public void NameTest() => ValueTest();
}
