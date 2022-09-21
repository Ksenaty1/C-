/* 
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число => ");
string a_str = Console.ReadLine();
int a = int.Parse(a_str);
Console.Write("Введите второе число => ");
string b_str = Console.ReadLine();
int b = int.Parse(b_str);
if (a > b)
{
    Console.WriteLine($"Максимальное число: {a}, Минимальное число: {b}");
}
else
{
    Console.WriteLine($"Максимальное число: {b}, Минимальное число: {a}");
}