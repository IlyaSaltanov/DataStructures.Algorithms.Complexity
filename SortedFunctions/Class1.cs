using System.ComponentModel.Design.Serialization;
using System.IO.Pipelines;

namespace SortedFunctions;

public class BubbleSort
{
    public static int[] Sort(int[] array)
    {
        int[] result = (int[])array.Clone();

        for (int i = 0; i < result.Length; i++)
        {
            for (int y = 0; y < result.Length; y++)
            {
                if (result[y] > result[y + 1])
                {
                    Swap(result, y, y + 1);
                }
            }
        }

        return result;
    }
    
    public static void Swap(int[] array, int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}
