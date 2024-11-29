using Nc.Domain.Common;
using Nc.Domain.Network.Components;

namespace Nc.Tests.Domain.Common;

[TestClass] public class IOrderedRepoTests : InterfaceTests<IOrderedRepo<Router>, IFilteredRepo<Router>> {
    [TestMethod] public void SortOrderTest() => PropertyTest<string>();
}