﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;

while (count<=N)
{
    double N3 = Math.Pow(count, 3);
    Console.Write(N3);
    if (count != N)
    {
        Console.Write(", ");
    }
    count++;
}