// Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();

Console.Write("Введите число :");
int num = int.Parse(Console.ReadLine()!);
int sqrNum = 0;
int result = 1;

for (int i = 1; i <= num; i++)
{
    sqrNum = i * i * i;
    if (sqrNum % 2 == 0)
    {
        Console.WriteLine(sqrNum);
    }
}
//  Показывает кубы чисел от 1 до num

