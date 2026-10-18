namespace Generics;

public static class EnumerableExtensions
{
    public static IEnumerable<T> Page<T>(
        this IEnumerable<T> source,
        int pageNumber,
        int pageSize)
    {
        ArgumentNullException.ThrowIfNull(source);

        if (pageNumber < 1)
            throw new ArgumentOutOfRangeException(nameof(pageNumber));

        if (pageSize < 1)
            throw new ArgumentOutOfRangeException(nameof(pageSize));

        long startIndex = ((long)pageNumber - 1) * pageSize;

        return GetPage(source, startIndex, pageSize);
    }

    private static IEnumerable<T> GetPage<T>(
        IEnumerable<T> source,
        long startIndex,
        int pageSize)
    {
        long index = 0;
        long endIndex = startIndex + pageSize;

        foreach (var item in source)
        {
            if (index >= startIndex)
            {
                yield return item;

                if (index == endIndex - 1)
                    yield break;
            }

            index++;
        }
    }

    public static T? FindById<T>(
        this IEnumerable<T> source,
        int id)
        where T : IHasId
    {
        ArgumentNullException.ThrowIfNull(source);

        foreach (var item in source)
        {
            if (item.Id == id)
                return item;
        }

        return default;
    }

    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(
        this IEnumerable<T> source)
        where T : IHasId
    {
        ArgumentNullException.ThrowIfNull(source);

        var dictionary = new Dictionary<int, T>();

        foreach (var item in source)
            dictionary.Add(item.Id, item);

        return dictionary;
    }
}