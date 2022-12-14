/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


int Func(int m, int n)
{
    if (m == 0)
    {
            return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Func(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Func(m - 1, Func(m, n - 1));
    }
    return Func(m, n);
}


int m = 3;
int n = 2;
Console.WriteLine(Func(m, n));
