/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int[,] RandomMatrix()
{
    Random rnd = new Random();
    int[,] matrix = new int[3, 4];
    for(int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matrix[i, j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}


void ShowMatrix(int[,] matrix)
{
    for(int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void AverageColumn(int[,] matrix)
{
    double average = 0;
    for(int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            average = average + matrix[j, i];
        }
        average =  average / 3;
        Console.WriteLine($"Average {i}-го столбца: {average:f2}");
        average = 0;
    }
}



int[,] matrix = RandomMatrix();
ShowMatrix(matrix);
AverageColumn(matrix);

