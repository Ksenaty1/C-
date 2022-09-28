/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/


Console.Write("Введите первое число => ");
string a_str = Console.ReadLine();
int a = int.Parse(a_str);
Console.Write("Введите второе число => ");
string b_str = Console.ReadLine();
int b = int.Parse(b_str);
Console.Write("Введите третье число => ");
string c_str = Console.ReadLine();
int c = int.Parse(c_str);
if (a > b & a > c) Console.WriteLine($"Максимальное число: {a}");
if (b > a & b > c) Console.WriteLine($"Максимальное число: {b}");
if (c > b & c > a) Console.WriteLine($"Максимальное число: {c}");