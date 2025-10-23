namespace Carbonsoft.Common.WebApi.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<T> AsNotNull<T>(this IEnumerable<T> sequence)
    {
        return sequence ?? [];
    }
}
