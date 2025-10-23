namespace Carbonsoft.Common.WebApi.Extensions;

public static class DictionaryExtensions
{
    public static bool AreEqual<TKey, TValue>(this IDictionary<TKey, TValue>? first, IDictionary<TKey, TValue>? second)
        where TValue : class
    {
        if (first is null && second is null) return true;

        if (first is null || second is null) return false;

        if (first.Count != second.Count) return false;

        return first.All(x => second.ContainsKey(x.Key) && x.Value == second[x.Key]);
    }
}
