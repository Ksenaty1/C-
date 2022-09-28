/*
 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
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
    if (number > 99) return true;
    else return false;
}

int number = GetNumber();
if (CheckNumber(number) == true)
{
    int firstNumber = number;
    while (number > 999){
        number = number / 10;
    }
    Console.WriteLine($"{firstNumber} -> {number % 10}");
}
else Console.WriteLine($"{number} -> третьей цифры нет");