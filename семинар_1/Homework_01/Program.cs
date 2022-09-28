/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int GetNumber()
{
    Console.Write("Введите число: ");
    string numberStr = Console.ReadLine();
    int number = int.Parse(numberStr);
    return number;
}

int SecondNumber(int number)
{
    return (number % 100 - number % 10) / 10;
}

int number = GetNumber();
Console.WriteLine($"{number} -> {SecondNumber(number)}");