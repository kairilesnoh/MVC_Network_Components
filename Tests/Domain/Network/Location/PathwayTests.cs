using Nc.Data.Network.Location;
using Nc.Domain.Network.Location;

namespace Nc.Tests.Domain.Network.Location; 
[TestClass] public class PathwayTests : LocationDomainClassTests<Pathway, PathwayData> {
    [TestMethod] public void TotalDistanceTest() => ValueTest();
}
