using Nc.Helpers.Extensions;

namespace Nc.Tests.Helpers.Extensions;
[TestClass] public class ListHelperTests {
    private readonly List<string> _list = ["LC", "SC", "MTP", "ST", "FC", "Other"];
    [TestMethod] public void RandomTest() => Assert.IsTrue(_list.Contains(ListHelper.Random(_list)));
}