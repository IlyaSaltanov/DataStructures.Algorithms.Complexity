using System;
using System.IO.Pipelines;
using static SortedFunctions.ICanSorted;
using static SortedFunctions.BasicFunctionsForHelp;

namespace SortedFunctions;

public class SelectionSort : ICanSorted
{
    public static int[] Sort(int[] array)
    {
        var result = (int[])array.Clone();

        for (int i = 0; i < result.Length - 1; i++)
        {
            for (int y = i + 1; y < result.Length; y++)
            {
                if (result[i] > result[y])
                    Swap(result, i, y);
            }
        }

        return result;
    }
}
