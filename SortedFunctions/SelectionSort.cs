using System;
using System.IO.Pipelines;
using static SortedFunctions.ICanSorted;
using static SortedFunctions.BasicFunctionsForHelp;
using System.Globalization;

namespace SortedFunctions;

public class SelectionSort : ICanSorted
{
    public static int[] Sort(int[] array)
    {
        var result = (int[])array.Clone();

        for (int i = 0; i < result.Length - 1; i++)
        {
            var min_index = i;
            for (int j = i + 1; j < result.Length; j++)
            {
                if (result[j] < result[min_index])
                {
                    min_index = j;
                }
            }
            Swap(result, min_index, i);
        }
        return result;
    }
}
