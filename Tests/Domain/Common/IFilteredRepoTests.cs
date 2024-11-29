using Nc.Domain.Common;
using Nc.Domain.Network.Components;

namespace Nc.Tests.Domain.Common;

[TestClass] public class IFilteredRepoTests : InterfaceTests<IFilteredRepo<Router>, ICrudRepo<Router>> {
    [TestMethod] public void SearchStringTest() => PropertyTest<string>();
    [TestMethod] public void FixedFilterTest() => PropertyTest<string>();
    [TestMethod] public void FixedValueTest() => PropertyTest<string>();
}