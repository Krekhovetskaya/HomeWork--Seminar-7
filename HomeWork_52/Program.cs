//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
WriteLine("Среднее арифметическое в столбцах : ");
PrintArrayOneDim(GetAverInColumn(array));
//WriteLine($"Среднее арифметическое в столбце = {GetAverInColumn(array)}");


int[,] GetArray(int m, int n, int minValue, int maxValue) //m кол-во строк n кол-во элементов в каждой строке
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) // перебор строк
    {
        for (int j = 0; j < n; j++) // перебор каждого элемента в строке
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

double[] GetAverInColumn(int[,] array)
{
    double[] aver = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        aver[j] = Convert.ToDouble(sum) / array.GetLength(0);
    }
    return aver;
}

void PrintArrayOneDim(double[] array)
{
   foreach(double i in array) // перебор значений, i переменная в ктр будет храниться значение
   {
        Write($"{i} ");
    }
        WriteLine();
    }

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}