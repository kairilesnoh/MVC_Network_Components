namespace Nc.Helpers.Extensions;

public static class ListExtension {
    public static T Random<T>(this IEnumerable<T> input) => ListHelper.Random(input);
}
