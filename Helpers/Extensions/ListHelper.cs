namespace Nc.Helpers.Extensions;

public static class ListHelper {
    private static readonly Random _random;
    static ListHelper() => _random = new Random();
    public static T Random<T>(IEnumerable<T> list) => list.ElementAt(_random.Next(list.Count()));
}
