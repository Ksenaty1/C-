/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

//Задаем координаты точки A
Console.Write("Введиме координату X точки A: ");
int coord_a_x = int.Parse(Console.ReadLine());
Console.Write("Введиме координату Y точки A: ");
int coord_a_y = int.Parse(Console.ReadLine());
Console.Write("Введиме координату Z точки A: ");
int coord_a_z = int.Parse(Console.ReadLine());


//Задаем координаты точки B
Console.Write("Введиме координату X точки B: ");
int coord_b_x = int.Parse(Console.ReadLine());
Console.Write("Введиме координату Y точки B: ");
int coord_b_y = int.Parse(Console.ReadLine());
Console.Write("Введиме координату Z точки B: ");
int coord_b_z = int.Parse(Console.ReadLine());

// Вычисляем расстояние
double distance = Math.Sqrt(Math.Pow(coord_a_x - coord_b_x, 2) + Math.Pow(coord_a_y - coord_b_y, 2) + Math.Pow(coord_a_z - coord_b_z, 2));
Console.WriteLine($"Расстояние: {distance}");