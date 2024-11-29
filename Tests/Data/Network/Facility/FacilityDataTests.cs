using Nc.Data;
using Nc.Data.Network.Facility;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Facility;
[TestClass] public class FacilityDataTests : SealedNewTests<FacilityData, EntityData> {
    [TestMethod] public void FacilityTypeIdTest() => PropertyTest();
}
