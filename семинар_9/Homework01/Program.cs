﻿/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


string Func(int n)
{
    if(n == 1)
    {
        return "1";
    }
    else
    {
        return string.Concat(n.ToString(), ", ", Func(n-1));
    }
}

Console.Write("Введите значение N : ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Func(n));