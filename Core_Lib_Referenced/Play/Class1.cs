using System;

static class C
{

    public static IEnumerable<T> DistinctPreserveOrder<T>(this IReadOnlyCollection<T> collection)
    {
        var set = new HashSet<T>(collection.Count);

        foreach (var item in collection)
        {
            if (set.Add(item))
            {
                yield return item;
            }
        }
    }

}