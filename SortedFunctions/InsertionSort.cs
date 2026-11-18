using System;
using static SortedFunctions.BasicFunctionsForHelp;

namespace SortedFunctions;

public class InsertionSort
{
    public static int[] Sort(int[] array)
    {
        var result = (int[])array.Clone();
        for (int i = 1; i < array.Length; i++)
        {
            var temp = result[i];
            var j = i;
            for (; j > 0 && result[j - 1] > temp; j--)
            {
                result[j] = result[j-1];
            }
            result[j] = temp;
        }

        return result;
    }
}
