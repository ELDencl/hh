// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();

Console.WriteLine("Введите координаты точки A: ");
Console.Write("X: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Y: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Z: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Y: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Z: ");
int z2 = int.Parse(Console.ReadLine()!);



double x3 = Math.Pow(x1 - x2, 2);
double y3 = Math.Pow(y1 - y2, 2);
double z3 = Math.Pow(z1 - z2, 2);

double C = Math.Sqrt(x3 + y3 + z3);

Console.WriteLine(Math.Round(C, 2)); // 2 способа вывода двух знаков после запятой
Console.WriteLine($"{C:f2}");