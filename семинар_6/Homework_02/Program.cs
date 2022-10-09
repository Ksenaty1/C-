﻿/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Write("Введите значение k1: ");
float k1 = float.Parse(Console.ReadLine());
Console.Write("Введите значение b1: ");
float b1 = float.Parse(Console.ReadLine());
Console.Write("Введите значение k2: ");
float k2 = float.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
float b2 = float.Parse(Console.ReadLine());


float x = - (b1 - b2) / (k1 - k2);
float y = k2 * x + b2;

Console.WriteLine($"({x}, {y})");
