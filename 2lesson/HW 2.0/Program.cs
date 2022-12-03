//Напишите программу, которая принимает на вход трехзначное 
//число и на выходе показывает вторую цифру этого числа


Console.WriteLine("Напишите трехзначное число:  ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(N(n));
int N(int num)
{
    int num = 0;
    if(99 < num)
    {
        if (num < 1000)
           int num = num % 10;
            
    else
        Console.WriteLine("Число не трехщначное");
    }
}

