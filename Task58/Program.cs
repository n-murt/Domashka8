// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using System;
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int y = Convert.ToInt32(Console.ReadLine());
        int[,] matrix1 = new int[x, y];
        Console.WriteLine("Массив 1:");
        PrintArray(FillArray(matrix1));
        int[,] matrix2 = new int[x, y];
        Console.WriteLine("Массив 2:");
        PrintArray(FillArray(matrix2));
        Console.WriteLine("Массив 3 результат перемножения:");
        PrintArray(MultiplyArray(matrix1, matrix2));

    }

    static int[,] FillArray(int[,] array)
    {
        Random rand = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rand.Next(0, 10);
            }
        }
        return array;
    }
    static int[,] PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        return array;
    }
    static int[,] MultiplyArray(int[,] array1, int[,] array2)
    {
        int[,] array3 = new int[array1.GetLength(0), array1.GetLength(1)];
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                array3[i, j] = array1[i, j] * array2[i, j];
            }
        }
        return array3;
    }

}
