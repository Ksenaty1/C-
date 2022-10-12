/*
Напишите программу, которая на вход принимает число и возвращает позицию (i, j) этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/

int[,] RandomMatrix()
{
    Random rnd = new Random(255);
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

void SearchNumber(int[,] matrix, int number)
{
    bool flag = false;
    for(int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (matrix[i, j] == number) 
            {
                Console.WriteLine($"Позиция: ({i}, {j})");
                flag = true;
                break;
            };

        }
        if (flag) break;
    }
    if (!flag) Console.WriteLine($"Такого числа нет в массиве");

}


Console.Write("Введите загаданное число: ");
int number = int.Parse(Console.ReadLine());
int[,] matrix = RandomMatrix();
ShowMatrix(matrix);
SearchNumber(matrix, number);