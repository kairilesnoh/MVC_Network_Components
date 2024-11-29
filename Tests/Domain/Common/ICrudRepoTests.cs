using Nc.Domain.Common;
using Nc.Domain.Network.Components;

namespace Nc.Tests.Domain.Common; 
[TestClass] public class ICrudRepoTests : InterfaceTests<ICrudRepo<Router>> {
    [TestMethod] public void GetAsyncListTest() => MethodTest<Task<IEnumerable<Router>>>("List");
    [TestMethod] public void GetAsyncTest() => MethodTest<Task<Router?>>(typeof(int));
    [TestMethod] public void FindAsyncTest() => MethodTest<Task<Router?>>(typeof(int));
    [TestMethod] public void UpdateAsyncTest() => MethodTest<Task<bool>>(typeof(Router));
    [TestMethod] public void AddAsyncTest() => MethodTest<Task<bool>>(typeof(Router));
    [TestMethod] public void DeleteAsyncTest() => MethodTest<Task<bool>>(typeof(int));
    [TestMethod] public void ErrorMessageTest() => PropertyTest<string>(false);
}
