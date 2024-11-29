using Nc.Data.Network.Location;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Location; 
[TestClass] public class GeographicBoundaryDataTests : SealedNewTests<GeographicBoundaryData, LocationData> {
    [TestMethod] public void NameTest() => PropertyTest();
}
