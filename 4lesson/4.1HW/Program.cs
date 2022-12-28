// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Sum(int num)
{
    int i = 1;
    int count = 0;
    int n = 0;

    while (i <= num)
    {
        
        count = num % 10;
        n = n + count;
        num = num / 10;
    
    }

    return n;

}

Console.WriteLine(Sum(int.Parse(Console.ReadLine())));