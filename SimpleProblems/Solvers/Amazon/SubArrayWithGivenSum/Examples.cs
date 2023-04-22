using SimpleProblems.Extensions;

namespace SimpleProblems.Solvers.Amazon.SubArrayWithGivenSum;

public class Examples
{
    private readonly IList<(int[], int)> _examples = new List<(int[], int)>()
    {
        (new[] { 1, 2, 3, 7, 5 }, 12),
        (new[] {1,2,3,4,5,6,7,8,9,10},15)
    };

    public void RunExamples()
    {
        foreach (var example in _examples)
        {
            var array = example.Item1;
            var sum = example.Item2;
            Console.WriteLine($"Array: [{array.JoinStr()}], Sum: {sum}");
            var indexes = Solver.Solve(array, sum);
            if (Solver.Validate(array, indexes.Item1, indexes.Item2, sum))
            {
                Console.WriteLine($"Solved: From index [{indexes.Item1+1}] to index [{indexes.Item2+1}]");
            }
            else
            {
                throw new Exception("Failed");
            }
        }
    }
}