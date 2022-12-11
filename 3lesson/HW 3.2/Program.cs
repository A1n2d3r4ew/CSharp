// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void M(int m)
{
    int i = 0;
    double a;
    while (i < m)
    {
        i ++;
        if (i == (m))
        {
            a = Math.Pow(i, 3);
            Console.Write($"{a}.");
        }
        else 
        {
            a = Math.Pow(i, 3);
            Console.Write($"{a}, ");
        }
    }
}

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
M(n);