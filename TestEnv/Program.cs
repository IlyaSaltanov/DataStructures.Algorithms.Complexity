// See https://aka.ms/new-console-template for more information






using SortedFunctions;

var array = new int[] { 5, 10, 6, 8, 12, 233, 22, 15, 12, 13, 10, 10, 13 };

Console.WriteLine("--------------------------------------------");
Console.WriteLine();

// Проверяем сортировку пузырьком
Console.WriteLine("Проверяем сортировку пузырьком:");


Console.WriteLine($"Было: {string.Join(", ", array)}");
Console.WriteLine($"Стало: {string.Join(", ", BubbleSort.Sort(array))}");


Console.WriteLine();
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

// Проверяем сортировку выбором - SelectionSort
Console.WriteLine("Проверяем сортировку выбором - SelectionSort:");

Console.WriteLine($"Было: {string.Join(", ", array)}");
Console.WriteLine($"Стало: {string.Join(", ", SelectionSort.Sort(array))}");

Console.WriteLine();
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

// Проверяем сортировку выбором - SelectionSort
Console.WriteLine("Проверяем сортировку вставками - InserctionSort:");

Console.WriteLine($"Было: {string.Join(", ", array)}");
Console.WriteLine($"Стало: {string.Join(", ", InsertionSort.Sort(array))}");


Console.WriteLine();
Console.WriteLine("--------------------------------------------");