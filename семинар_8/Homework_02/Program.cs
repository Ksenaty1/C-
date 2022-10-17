/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] RandomMatrix()
{
    Random rnd = new Random();
    int[,] matrix = new int[4, 4];
    for(int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for(int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindLowestLine(int[,] matrix)
{
    int lowest = 100000000;
    int lowest_line = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (sum < lowest)
        {
            lowest = sum;
            lowest_line = i;
        }
        sum = 0;
    }
    return lowest_line + 1;
}

int[,] array = RandomMatrix();
ShowMatrix(array);
Console.WriteLine("------------------------------");
Console.WriteLine(FindLowestLine(array));
