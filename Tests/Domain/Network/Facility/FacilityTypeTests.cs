using Nc.Data.Network.Facility;
using Nc.Domain.Network.Facility;

namespace Nc.Tests.Domain.Network.Facility;

[TestClass] public class FacilityTypeTests : FacilityDomainClassTests<FacilityType, FacilityTypeData> {
    [TestMethod] public void NameTest() => ValueTest();
}
