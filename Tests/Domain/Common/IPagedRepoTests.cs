using Nc.Domain.Common;
using Nc.Domain.Network.Components;

namespace Nc.Tests.Domain.Common; 
[TestClass] public class IPagedRepoTests : InterfaceTests<IPagedRepo<Router>, IOrderedRepo<Router>> {
    [TestMethod] public void PageNumberTest() => PropertyTest<int?>();
    [TestMethod] public void PageTest() => PropertyTest<int>(false);
    [TestMethod] public void PageSizeTest() => PropertyTest<int>();
    [TestMethod] public void TotalPagesTest() => PropertyTest<int>(false);
    [TestMethod] public void TotalItemsTest() => PropertyTest<int>(false);
    [TestMethod] public void HasNextPageTest() => PropertyTest<bool>(false);
    [TestMethod] public void HasPreviousPageTest() => PropertyTest<bool>(false);
}
