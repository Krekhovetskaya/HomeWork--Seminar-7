/*/Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
/*/

using System;
using static System.Console;

Clear();
Write("Введите m: ");
int n = int.Parse(ReadLine());
Write("Введите n: ");
int m = int.Parse(ReadLine());

WriteLine($"Cумма чисел = {SumNumbers(m, n)}");

int SumNumbers (int start, int end)
{
    if (start == end) return start;
    return (start + SumNumbers (start + 1, end));
}