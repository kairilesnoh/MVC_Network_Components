using Nc.Facade;
using Nc.Facade.Network.Facility;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Facility;

[TestClass] public class FacilityEntityViewModelTests: SealedNewTests<FacilityEntityViewModel, EntityViewModel>{
    [TestMethod] public void FacilityTypeIdTest() => PropertyTest("Facility Type Id");
}
