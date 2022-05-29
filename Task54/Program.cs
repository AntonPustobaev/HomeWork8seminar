// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

using System;
Console.Clear();

int m = ReadInteger("Введите количество строк m=");
int n = ReadInteger("Введите количество столбцов n=");
int minimum = -99;
int maximum = 99;

int[,] array = CreateArrayRandom(m, n, minimum, maximum);
Console.WriteLine("Массив:");
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1) - 1; j++)
        for (int k = j + 1; k < array.GetLength(1); k++)
        {
            if (array[i, k] > array[i, j])
            {
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }

Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
PrintArray(array);

int[,] CreateArrayRandom(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

int ReadInteger(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}