//Напишите программу, которая принимает на вход трехзначное 
//число и на выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1



string N(int num)
{
    if(num < 1000 && num > 99)
    {
        num = num / 10;
        return($"{num = num % 10}");
    }
    else
        return($"ошибка");
}

Console.WriteLine("Напишите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(N(a));
