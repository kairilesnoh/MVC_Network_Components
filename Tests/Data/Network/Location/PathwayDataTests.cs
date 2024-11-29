using Nc.Data.Network.Location;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Location; 
[TestClass] public class PathwayDataTests : SealedNewTests<PathwayData, LocationData> {
    [TestMethod] public void TotalDistanceTest() => PropertyTest();
}
