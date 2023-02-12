// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int y = Convert.ToInt32(Console.ReadLine());
        SortRowArray(x, y);
    }

    static int SortRowArray(int x, int y)
    {
        Random rand = new Random();
        int[,] array = new int[x, y];
        int[,] sortarray = new int[x, y];
        int[] rowarray = new int[y];
        Console.WriteLine("Массив: ");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                array[i, j] = rand.Next(0, 10);
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
            for (int j = 0; j < y; j++)
            {
                rowarray[j] = array[i, j];
            }
            Array.Sort(rowarray);
            Array.Reverse(rowarray);
            for (int j = 0; j < y; j++)
            {
                sortarray[i, j] = rowarray[j];
            }

        }
        Console.WriteLine();
        Console.WriteLine($"Отсортированный по строкам массив: ");

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write($"{sortarray[i, j]} ");
            }
            Console.WriteLine();
        }

        return 1;
    }

}