using SimpleProblems.Extensions;

namespace SimpleProblems.Solvers.ZigZag;

public class ZigZagArrayExamples
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
            example.Print();
            ZigZagArraySolver.Solve(example, example.Length);
            if (ZigZagArraySolver.Validate(example, example.Length))
            {
                Console.WriteLine();
                Console.WriteLine("Solved");
                example.Print();
            }
            else
            {
                throw new Exception("Failed");
            }
        }
    }
}