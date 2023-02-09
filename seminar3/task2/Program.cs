// Возведите число А в натуральную степень B используя цикл


Console.Clear();



Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральную степень числа А: ");
int step = int.Parse(Console.ReadLine()!);
int result = 1;

for (int i = 0; i < step; i++)
{
    result = result * A;
}


Console.WriteLine(result);