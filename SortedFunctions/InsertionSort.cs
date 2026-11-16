using System;
using static SortedFunctions.BasicFunctionsForHelp;

namespace SortedFunctions;

public class InsertionSort
{
    public static int[] Sort(int[] array)
    {
        var result = (int[])array.Clone();
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (result[j] < result[j-1])
                {
                    Swap(result, j, j - 1);
                }
            }
        }

        return result;
    }
}
