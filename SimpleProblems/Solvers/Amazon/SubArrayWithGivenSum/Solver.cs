namespace SimpleProblems.Solvers.Amazon.SubArrayWithGivenSum;

/**
 * Given an unsorted array A of size N that contains only positive integers, find a continuous sub-array that adds to a given number S and return the left and right index(1-based indexing) of that subarray.
 * In case of multiple subarrays, return the subarray indexes which come first on moving from left to right.
 * Note:- You have to return an ArrayList consisting of two elements left and right. In case no such subarray exists return an array consisting of element -1.
 */

public class Solver
{
    public static (int,int) Solve(int[] arr, int sum)
    {
        int temp = 0;
        int fromIdx = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            temp += arr[i];
            while (temp > sum && fromIdx < i)
            {
                temp -= arr[fromIdx];
                fromIdx++;
            }
            
            if (temp == sum)
                return (fromIdx, i);
        }

        throw new Exception("No sub array match the requirements");
    }

    public static bool Validate(int[] arr, int fromIdx, int toIdx, int sum)
    {
        var temp = 0;
        while (fromIdx <= toIdx)
        {
            temp += arr[fromIdx++];
        }

        return temp == sum;
    }
}