
// Напишите программу, которая принимает на вход число N
// и выдает произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

int Num(int n)
{
    int result = 1;
    
    for (int i = 1; i <= n; i++)
    {
        result = result * i;
    }
    return result;
}

Console.WriteLine(Num(int.Parse(Console.ReadLine())));