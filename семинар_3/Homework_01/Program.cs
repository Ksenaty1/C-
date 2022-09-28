/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/


int GetNumber()
{
    return int.Parse(Console.ReadLine());
}


int number = GetNumber();
if (number / 10000 == number % 10 && (number / 1000) % 10 == (number / 10) % 10) Console.WriteLine("палиндром");
else Console.WriteLine("Не палиндром");