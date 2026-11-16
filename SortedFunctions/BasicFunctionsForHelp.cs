using System;

namespace SortedFunctions;

public static class BasicFunctionsForHelp
{
    public static void Swap(int[] array, int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}
