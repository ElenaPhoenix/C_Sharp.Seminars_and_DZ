﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"сумма чисел от 1 до {N} равна {SummaFor(N)}");
Console.WriteLine($" {N} равна {SummaWhile(N)}");
Console.WriteLine($" {N} равна {SummaRec(N)}");

string SummaWhile(int N)
{
    string res = " ";
    while (true)
    {
        res = N.ToString() + res;
        N--;
        if (N == 0) break;
    }
    return res;
}