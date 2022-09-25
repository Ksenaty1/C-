/*
 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int GetNumber()
{
    Console.Write("Введите число: ");
    string numberStr = Console.ReadLine();
    int number = int.Parse(numberStr);
    return number;
}

bool CheckNumber(int number)
{
    if (number >= 1 && number <=7) return true;
    else return false;
}

string CheckDayOff(int number){
    if (number == 7 || number == 6) return "да";
    else return "нет";
}

int number = GetNumber();
if (CheckNumber(number)) Console.WriteLine($"{number} -> {CheckDayOff(number)}");
else Console.WriteLine("Вы ввели неверное значение");