using Nc.Facade.Network.Components;
using Nc.Helpers.Methods;

namespace Nc.Tests.Helpers.Methods; 
[TestClass] public class GetRandomTests : BaseTests {
    protected override Type? type => typeof(GetRandom);
    private readonly List<string> _list = ["LC", "SC", "MTP", "ST", "FC", "Other"];
    private readonly List<string> _capitalCities = [
        "Tirana", "Andorra la Vella", "Yerevan", "Vienna", "Baku", "Minsk", "Brussels", "Sarajevo", "Sofia", "Zagreb",
        "Nicosia", "Prague", "Copenhagen", "Tallinn", "Helsinki", "Paris", "Tbilisi", "Berlin", "Athens", "Budapest",
        "Reykjavik", "Dublin", "Rome", "Astana", "Pristina", "Riga", "Vaduz", "Vilnius", "Luxembourg", "Valletta",
        "Chisinau", "Monaco", "Podgorica", "Amsterdam", "Skopje", "Oslo", "Warsaw", "Lisbon", "Bucharest", "Moscow",
        "San Marino", "Belgrade", "Bratislava", "Ljubljana", "Madrid", "Stockholm", "Bern", "Ankara", "Kyiv", "London",
        "Vatican City", "Canberra", "Ottawa", "Beijing", "Tokyo", "New Delhi", "Jakarta", "Abuja", "Cairo", "Pretoria", "Riyadh",
        "Tehran", "Islamabad", "Baghdad", "Jerusalem", "Bangkok", "Kuala Lumpur", "Manila", "Seoul", "Hanoi", "Wellington"
    ];

    private static IEnumerable<Type[]> TestData() {
        yield return [typeof(string)];
        yield return [typeof(long)];
        yield return [typeof(long?)];
        yield return [typeof(int)];
        yield return [typeof(int?)];
        yield return [typeof(short?)];
        yield return [typeof(short)];
        yield return [typeof(sbyte)];
        yield return [typeof(sbyte?)];
        yield return [typeof(ulong)];
        yield return [typeof(ulong?)];
        yield return [typeof(uint)];
        yield return [typeof(uint?)];
        yield return [typeof(ushort)];
        yield return [typeof(ushort?)];
        yield return [typeof(byte)];
        yield return [typeof(byte?)];
        yield return [typeof(char)];
        yield return [typeof(char?)];
        yield return [typeof(double)];
        yield return [typeof(double?)];
        yield return [typeof(float)];
        yield return [typeof(float?)];
        yield return [typeof(DateTime)];
        yield return [typeof(DateTime?)];
        yield return [typeof(bool)];
        yield return [typeof(bool?)];
        yield return [typeof(decimal)];
        yield return [typeof(decimal?)];
    }

    [TestMethod, DynamicData(nameof(TestData), DynamicDataSourceType.Method)]
    public void AnyTest(Type? t) {
        var x = GetRandom.Any(t);
        var y = GetRandom.Any(t);
        while (x?.CompareTo(y) == 0) y = GetRandom.Any(t);
        Assert.AreNotEqual(x, y);
    }

    [TestMethod] public void ObjectTest() {
        var x = GetRandom.Object<RouterViewModel>();
        var y = GetRandom.Object<RouterViewModel>();
        var z = new RouterViewModel();
        Assert.IsInstanceOfType<RouterViewModel>(x);
        Assert.IsInstanceOfType<RouterViewModel>(y);
        AreNotEqualProperties(x, z);
        AreNotEqualProperties(x, y);
    }

    [TestMethod] public void BoolTest() => TestRandom(GetRandom.Bool);
    [TestMethod] public void CharTest() => TestRandom(() => GetRandom.Char(), GetRandom.Char);
    [TestMethod] public void DoubleTest() => TestRandom(() => GetRandom.Double(), GetRandom.Double);
    [TestMethod] public void DecimalTest() => TestRandom(() => GetRandom.Decimal(), GetRandom.Decimal);
    [TestMethod] public void DateTimeTest() => TestRandom(() => GetRandom.DateTime(), (x, y) => GetRandom.DateTime(x, y));
    [TestMethod] public void FloatTest() => TestRandom(() => GetRandom.Float(), GetRandom.Float);
    [TestMethod] public void Int64Test() => TestRandom(() => GetRandom.Int64(), GetRandom.Int64);
    [TestMethod] public void Int32Test() => TestRandom(() => GetRandom.Int32(), GetRandom.Int32);
    [TestMethod] public void Int16Test() => TestRandom(() => GetRandom.Int16(), GetRandom.Int16);
    [TestMethod] public void Int8Test() => TestRandom(() => GetRandom.Int8(), GetRandom.Int8);
    [TestMethod] public void StringTest() => Assert.AreNotEqual(GetRandom.String(), GetRandom.String());
    [TestMethod] public void UInt64Test() => TestRandom(() => GetRandom.UInt64(), GetRandom.UInt64);
    [TestMethod] public void UInt32Test() => TestRandom(() => GetRandom.UInt32(), GetRandom.UInt32);
    [TestMethod] public void UInt16Test() => TestRandom(() => GetRandom.UInt16(), GetRandom.UInt16);
    [TestMethod] public void UInt8Test() => TestRandom(() => GetRandom.UInt8(), GetRandom.UInt8);

    private static void TestRandom<T>(Func<T> f1, Func<T, T, T>? f2 = null) where T : IComparable<T> {
        TestRandom(f1, out T min, out T max);
        if (f2 is null)
            return;
        TestRandom(() => f2(min, max), out T x, out T y);
        if (min.CompareTo(max) < 0)
            IsBetween(x, min, max);
        else
            IsBetween(x, max, min);
    }

    private static void TestRandom<T>(Func<T> func, out T x, out T y) where T : IComparable<T> {
        x = func();
        y = func();
        while (x.CompareTo(y) == 0) {
            y = func();
        }
        Assert.AreNotEqual(x, y);
    }

    private static void TestRandom<T>(Func<T> func) where T : IComparable<T> {
        T x = func();
        T y = func();
        while (x.CompareTo(y) == 0) {
            y = func();
        }
        Assert.AreNotEqual(x, y);
    }

    private static void IsBetween<T>(T x, T min, T max) where T : IComparable<T> {
        Assert.IsTrue(x.CompareTo(max) <= 0);
        Assert.IsTrue(x.CompareTo(min) >= 0);
    }
}
