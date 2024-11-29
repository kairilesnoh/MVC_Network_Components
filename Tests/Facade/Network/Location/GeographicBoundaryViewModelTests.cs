using Nc.Facade.Network.Location;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Location; 
[TestClass] public class GeographicBoundaryViewModelTests : SealedNewTests<GeographicBoundaryViewModel, LocationEntityViewModel> {
    [TestMethod] public void NameTest() => PropertyTest("Boundary Name");
}
