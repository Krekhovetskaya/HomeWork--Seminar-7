/*/Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*/

using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n = int.Parse(ReadLine());
for (int i = n; i >= 1; i--)
{
    Write($"{i} ");
}
WriteLine();

void  PrintNumbers(int n) //передали целое число n
{
    if (n < 1)// условие выхода, если n меньше единицы
    {
       return;
    }
    Write(n.ToString() + " ");
    PrintNumbers(n - 1);
    
}
