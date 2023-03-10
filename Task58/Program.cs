/*/Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
/*///15 18

using System;
using static System.Console;

Clear();

Write("Введите количество строк 1 массива: ");
int rowsA=int.Parse(ReadLine());
Write("Введите количество столбцов 1 массива: ");
int columnsA=int.Parse(ReadLine());

Write("Введите количество строк 2 массива: ");
int rowsB=int.Parse(ReadLine());
Write("Введите количество столбцов 2 массива: ");
int columnsB=int.Parse(ReadLine());

int[,] A = GetArray(rowsA, columnsA, 0, 10);
int[,] B = GetArray(rowsB, columnsB, 0, 10);

PrintArray(A);
WriteLine();
PrintArray(B);
WriteLine();
if (CheckMultiply(columnsA, rowsB))
{
    PrintArray(GetMultiMatrix(A, B));    
}


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
bool CheckMultiply(int colsA, int rowsB) 
{
    if (colsA != rowsB) {
        WriteLine("Нельзя перемножать. Количество столбцов в матрице А должно быть равно количеству строк в матрице B");
        return false;
    }
    return true;
}

int[,] GetMultiMatrix(int[,] arrayA, int[,] arrayB)
{
    int [,] arrayC = new int [ arrayA.GetLength(0),  arrayB.GetLength(1)];
    for  (int i=0; i < arrayA.GetLength(0); i++ ) 
    {
        for (int j=0; j < arrayB.GetLength(1); j++ )
        {
            for (int k=0; k < arrayB.GetLength(0); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}