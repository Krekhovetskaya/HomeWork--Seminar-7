// задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

using System;
using static System.Console;


    Write("введите номер строки\n");
    int row = int.Parse(ReadLine());
    Write("введите номер столбца\n");
    int column = int.Parse(ReadLine());
    int[,] array = new int[6, 8];
    FillArray(array);
    PrintArray(array);
    
    if (CheckIndex(row, column)) 
    {
        GetElement(array, row, column);   
    }
   
    void FillArray (int [,] array)
    {
    for(int i = 0; i < array.GetLength(0); i++)
    {
            for(int j = 0; j < array.GetLength(1); j++) 
        {
            array [i , j]  = new Random (). Next ( 1 ,  10 );;
        }
    }
    }
   
    bool CheckIndex(int row, int column)
    {
        if (row >= array.GetLength(0) || column >= array.GetLength(1)) {
            Write("такого числа в массиве нет");
            return false;
        }
        return true;
    }
    
    void PrintArray(int[,] array) {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++) 
            {    
                Write($"{array[i, j]} ");
            }
            Write("\n");
        }
    }
   
    void GetElement(int[,] array, int row, int column) {
        Write($"Ваше значение {array[row, column]}");
    }