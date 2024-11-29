using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;

namespace Nc.Tests.Domain.Network.Components; 
[TestClass] public class FilterTests : DeviceDomainClassTests<Filter, FilterData> {
    [TestMethod] public void FilterTypeTest() => ValueTest();
}
