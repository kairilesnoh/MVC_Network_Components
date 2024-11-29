using Nc.Helpers.Extensions;

namespace Nc.Tests.Helpers.Extensions; 
[TestClass] public class ListExtensionTests {
    private readonly List<string> _list = ["LC", "SC", "MTP", "ST", "FC", "Other"];
    [TestMethod] public void RandomTest() => Assert.IsTrue(_list.Contains(_list.Random()));
}
