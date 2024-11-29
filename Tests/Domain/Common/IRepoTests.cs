using Nc.Domain.Common;
using Nc.Domain.Network.Components;

namespace Nc.Tests.Domain.Common; 
[TestClass] public class IRepoTests : InterfaceTests<IRepo<Router>, IPagedRepo<Router>> {
    [TestMethod] public void SelectItemsTest() => MethodTest<Task<IEnumerable<dynamic>>>(typeof(string), typeof(int));
    [TestMethod] public void SelectItemTest() => MethodTest<Task<dynamic>>(typeof(int));
}
