// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void N(int n)
{
    Console.Write($"{n}    ");
    if (n < 100)
    {
        Console.WriteLine($"третьей цифры нет");
        return;
    }
    while (n > 999) n /= 10;
    Console.WriteLine(n % 10);
}

N(int.Parse(Console.ReadLine()));