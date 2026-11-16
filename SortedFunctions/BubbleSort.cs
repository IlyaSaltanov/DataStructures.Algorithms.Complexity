using System.ComponentModel.Design.Serialization;
using System.IO.Pipelines;

using static SortedFunctions.BasicFunctionsForHelp;

namespace SortedFunctions;

public static class BubbleSort
{
    public static int[] Sort(int[] array)
    {
        int[] result = (int[])array.Clone();

        for (int i = 0; i < result.Length; i++)
        {
            for (int y = 0; y < result.Length - 1; y++)
            {
                if (result[y] > result[y + 1])
                {
                    Swap(result, y, y + 1);
                }
            }
        }

        return result;
    }
}
