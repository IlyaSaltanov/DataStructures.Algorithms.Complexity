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
            for (; j > 0; j--)
            {
                if (result[j - 1] > temp)
                {
                    // Swap(result, j, j-1);
                    result[j] = result[j-1];
                }
                else {
                    break;
                }
            }
            result[j] = temp;
        }

        return result;
    }
}
