using System;
using System.Collections.Generic;
using System.Linq;

namespace KnapsackApp
{
    // 1. Создаем свою структуру данных для предмета
    public class Item
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Value { get; set; }

        public Item(string name, int weight, int value)
        {
            Name = name;
            Weight = weight;
            Value = value;
        }
    }

    class Program
    {
        static void Main()
        {
            // 2. Инициализируем список предметов
            List<Item> items = new List<Item>
            {
                new Item("A", 1, 2),
                new Item("B", 3, 5),
                new Item("C", 4, 6),
                new Item("D", 5, 7)
            };

            int capacity = 7;
            int n = items.Count;

            // 3. Создаем таблицу динамического программирования
            int[,] dp = new int[n + 1, capacity + 1];

            // 4. Заполняем таблицу DP
            for (int i = 1; i <= n; i++)
            {
                Item currentItem = items[i - 1];

                for (int w = 0; w <= capacity; w++)
                {
                    if (currentItem.Weight <= w)
                    {
                        // Выбираем максимум: либо не берем предмет, либо берем его
                        dp[i, w] = Math.Max(
                            dp[i - 1, w],
                            dp[i - 1, w - currentItem.Weight] + currentItem.Value
                        );
                    }
                    else
                    {
                        dp[i, w] = dp[i - 1, w];
                    }
                }
            }

            int maxValue = dp[n, capacity];
            Console.WriteLine($"Максимальная ценность: {maxValue}");

            // 5. Восстановление выбранных предметов (обратный ход)
            List<Item> chosenItems = new List<Item>();
            int currentCapacity = capacity;

            for (int i = n; i > 0 && currentCapacity > 0; i--)
            {
                // Если значение в текущей ячейке отличается от значения сверху, значит предмет был взят
                if (dp[i, currentCapacity] != dp[i - 1, currentCapacity])
                {
                    Item selectedItem = items[i - 1];
                    chosenItems.Add(selectedItem);
                    currentCapacity -= selectedItem.Weight;
                }
            }

            chosenItems.Reverse();

            // Вывод результатов
            Console.WriteLine("Выбранные предметы:");
            int totalWeight = 0;
            foreach (var item in chosenItems)
            {
                Console.WriteLine($"- {item.Name} (Вес: {item.Weight}, Ценность: {item.Value})");
                totalWeight += item.Weight;
            }
            Console.WriteLine($"Общий вес: {totalWeight} кг");
        }
    }
}