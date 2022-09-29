/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/ 

void ShowArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write(array[i] + " ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

Console.Write("Введите массив: ");
string[] array_str = new string[8];
array_str = Console.ReadLine().Split();
ShowArray(array_str);