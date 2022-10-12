/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


double[,] RandomMatrix(int m, int n)
{
    Random rnd = new Random();
    double[,] matrix = new double[m, n];
    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Convert.ToDouble(rnd.Next(-99, 100)) / 10;
        }
    }
    return matrix;
}

void ShowMatrix(double[,] matrix, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
double[,] matrix = RandomMatrix(m, n);
ShowMatrix(matrix, m, n);
