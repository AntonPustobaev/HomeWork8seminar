//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using System;
Console.Clear();

int[,] firstArray = GetFirstArray(5, 5, 1, 9);
int[,] secondArray = GetSecondArray(5, 5, 1, 9);
PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);
Console.WriteLine();
PrintArray(GetMultyArray(firstArray, secondArray));



int[,] GetFirstArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] firstResult = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            firstResult[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return firstResult;
}

int[,] GetSecondArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] secondResult = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            secondResult[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return secondResult;
}

void PrintArray(int[,] array)
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

int[,] GetMultyArray(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] multyArray = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0 ; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                multyArray[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return multyArray;
}