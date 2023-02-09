// Определить количество цифр в числе



Console.Clear();

Console.Write("Введите число: ");

int num = int.Parse(Console.ReadLine()!);

int count = 0;

while(num != 0)
{
    num = num/10;
    count ++;

}

Console.WriteLine($"В числе {num}, {count} цифр");









// Другое решение для нуля и других чисел


// Определить количество цифр в числе

// Console.Clear();

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine()!);

// int count = 1;

// while (a >= 10 || a <= -10)
// {
// a = a / 10;
// count ++;
// }

// Console.WriteLine(count);