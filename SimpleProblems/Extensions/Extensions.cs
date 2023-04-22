namespace SimpleProblems.Extensions;

public static class Extensions
{
    public static string JoinStr(this IEnumerable<int> array, char separator = ',')
    {
        return string.Join(separator, array);
    }
}