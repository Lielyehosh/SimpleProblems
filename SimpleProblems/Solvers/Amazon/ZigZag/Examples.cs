using SimpleProblems.Extensions;

namespace SimpleProblems.Solvers.Amazon.ZigZag;

public class Examples
{
    private readonly IList<int[]> _examples = new List<int[]>()
    {
        new[] { 1, 6, 7, 3, 5, 989, 35, 2 },
        new[] { 1, 2, 5, 9, 5, 989, 35, 87, 48, 22 }
    };
    
    public void RunExamples()
    {
        foreach (var example in _examples)
        {
            Console.WriteLine();
            Console.WriteLine($"Input: Array=[{example.JoinStr()}]");
            Solver.Solve(example, example.Length);
            if (Solver.Validate(example, example.Length))
            {
                Console.WriteLine($"Output: Array=[{example.JoinStr()}]");
            }
            else
            {
                throw new Exception("Failed");
            }
        }
    }
}