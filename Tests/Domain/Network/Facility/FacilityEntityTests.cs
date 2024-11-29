using Nc.Data.Network.Facility;
using Nc.Domain.Network.Facility;

namespace Nc.Tests.Domain.Network.Facility;

[TestClass] public class FacilityEntityTests : FacilityDomainClassTests<FacilityEntity, FacilityData> {
    [TestMethod] public void FacilityTypeIdTest() => ValueTest();
}
