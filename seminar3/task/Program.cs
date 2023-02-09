// найти сумму чисел от 1 до A



Console.Clear();

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
int sum = 0;
for (int i = 0; i <= A; i++)
{
   sum += i;
}

Console.WriteLine($"Сумма чисел от 1 до {A} равна {sum}");