using Nc.Data.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Components; 
[TestClass] public class FilterDataTests : SealedNewTests<FilterData, DeviceData> {
    [TestMethod] public void FilterTypeTest() => PropertyTest();
}
