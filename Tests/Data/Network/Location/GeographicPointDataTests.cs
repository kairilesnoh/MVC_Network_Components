using Nc.Data.Network.Location;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Location; 
[TestClass] public class GeographicPointDataTests : SealedNewTests<GeographicPointData, LocationData> {
    [TestMethod] public void LatitudeTest() => PropertyTest();
    [TestMethod] public void LongitudeTest() => PropertyTest();
}
