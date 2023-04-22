namespace SimpleProblems.Solvers.Amazon.ZigZag;

/**
 * Source: https://practice.geeksforgeeks.org/problems/convert-array-into-zig-zag-fashion1638/1?page=1&company[]=Amazon&curated[]=1&sortBy=submissions
 * Given an array arr of distinct elements of size N, the task is to rearrange the elements of the array in a zig-zag fashion so that the converted array should be in the below form:
 * arr[0] < arr[1]  > arr[2] < arr[3] > arr[4] < . . . . arr[n-2] < arr[n-1] > arr[n].
 * NOTE: If your transformation is correct, the output will be 1 else the output will be 0. 
 */
public class Solver
{
    public static void Solve(int[] array, int N)
    {
        for (var i = 0; i < N - 1; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > array[i + 1])
                {
                    Swap(array, i);
                }
            }
            else
            {
                if (array[i] < array[i + 1])
                {
                    Swap(array, i);
                }
            }
        }
    }

    public static bool Validate(int[] array, int n)
    {
        for (var i = 0; i < n - 1; i++)
        {
            if (i % 2 == 0 && array[i] > array[i + 1])
                return false;

            if (i % 2 != 0 && array[i] < array[i + 1])
                return false;
        }

        return true;
    }

    private static void Swap(int[] array, int idx)
    {
        (array[idx], array[idx + 1]) = (array[idx + 1], array[idx]);
    }
}