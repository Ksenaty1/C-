/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] ConvertArray(string[] array_str, int M)
{
    int[] array = new int[M];
    for(int i = 0; i < M; i++)
    {
        array[i] = int.Parse(array_str[i]);
    }

    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write(array[i] + " ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

int CountPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum++;
    }
    return sum;
}


Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine());
string[] array_str = new string[M];
Console.WriteLine("Введите числа: ");
array_str = Console.ReadLine().Split(",");
int[] array = ConvertArray(array_str, M);
Console.WriteLine($"Количество положительныч чисел: {CountPositive(array)}");