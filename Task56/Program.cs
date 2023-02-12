// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
using System;
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Cтрока с наименьшей суммой элементов: {MinSumArray(x, y)}"); ;
    }

    static int MinSumArray(int x, int y)
    {
        Random rand = new Random();
        int[,] array = new int[x, y];

        int minsum = 0;
        int row = 0;
        Console.WriteLine("Массив: ");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                array[i, j] = rand.Next(0, 10);
                Console.Write($"{array[i, j]} ");
            }

            int rowsum = 0;
            for (int j = 0; j < y; j++)
            {
                rowsum += array[i, j];
            }
            Console.Write($" - {rowsum}");
            Console.WriteLine();
            if (i == 0)
            {
                minsum = rowsum;
            }
            if (rowsum <= minsum)
            {
                row = (i + 1);
            }

        }
        Console.WriteLine();

        return row;
    }

}