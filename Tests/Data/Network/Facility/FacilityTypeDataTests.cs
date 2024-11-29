using Nc.Data.Network.Facility;
using Nc.Data;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Facility;
[TestClass] public class FacilityTypeDataTests : SealedNewTests<FacilityTypeData, EntityData>{
    [TestMethod] public void NameTest() => PropertyTest();
}
