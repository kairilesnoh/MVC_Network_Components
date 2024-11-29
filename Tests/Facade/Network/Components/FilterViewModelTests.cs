using Nc.Facade.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Components; 
[TestClass] public class FilterViewModelTests : SealedNewTests<FilterViewModel, DeviceViewModel> {
    [TestMethod] public void FilterTypeTest() => PropertyTest("Filter Type");
}
