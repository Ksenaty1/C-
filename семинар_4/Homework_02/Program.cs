/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/ 


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int number_sum = 0;
while (number != 0)
{
    number_sum = number_sum + number % 10;
    number = number / 10;
}
Console.WriteLine($"Сумма цифр: {number_sum}");