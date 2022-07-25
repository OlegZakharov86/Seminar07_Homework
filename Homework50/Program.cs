//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

using System.Linq;

namespace Seminar7
{
    class Homework50
    {
        public static void Main()
        {
            Console.WriteLine("Введите позицию элемента в двумером массиве:");
            int[] position = new int[2];
            position = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int m = 3;
            int n = 4;
            int[,] array = new int[m, n];
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();

            if (
                position[0] > -1 &&
                position[0] <= m &&
                position[1] > -1 &&
                position[1] <= n
                )
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (position[0] == i && position[1] == j) Console.WriteLine($"{array[i,j]} ");
                    }
                }
            }
            else Console.WriteLine($"такого числа в массиве нет");
        }
        public static void FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 11);
                }
            }
        }

        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

