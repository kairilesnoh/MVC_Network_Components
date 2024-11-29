using Nc.Facade;
using Nc.Facade.Network.Facility;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Facility;

[TestClass] public class FacilityTypeViewModelTests : SealedNewTests<FacilityTypeViewModel, EntityViewModel> {
    [TestMethod] public void NameTest() => PropertyTest("Name");
    [TestMethod] public void FacilityEntitiesTest() {
        var model = new FacilityTypeViewModel();
        var facilityEntities = new List<FacilityEntityViewModel> {
                new(),
                new()
            };
        model.FacilityEntities = facilityEntities;
        Assert.AreEqual(facilityEntities, model.FacilityEntities);
    }
}
