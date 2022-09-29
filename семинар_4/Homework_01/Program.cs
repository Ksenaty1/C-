/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


//Вводим числа
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

//Возводим A в натуральную степень B
int number = a;
for (int i = 1; i < b; i++)
{
    number = number * a;
}

//Выводим полученное значение
Console.WriteLine($"{number}");