namespace SimpleProblems.Extensions;

public static class Extensions
{
    public static void Print(this IEnumerable<int> array)
    {
        foreach (var num in array)
        {
            Console.Write($"{num} ");
        }
    }
}