// Подсчитать сумму цифр в числе



Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = 0;

while (num != 0)
{
    result += (num % 10);
    num = num / 10;
}

Console.WriteLine(result);
