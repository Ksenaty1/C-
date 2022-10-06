/*
 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] InitArray(int dimension)
{

    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(100,1000);
    }

    return arr;
}


void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CountEven(int[] array)
{
    int sum_even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) sum_even++;
    }
    return sum_even;
}


int[] array = InitArray(10);
ShowArray(array);
Console.WriteLine($"Количество нечетных элементов: {CountEven(array)}");