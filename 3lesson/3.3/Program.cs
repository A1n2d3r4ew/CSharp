// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1,4,9,16,25.
// 2 -> 1,4

void N(int n)
{
    int i = 0;
    double pere;
    while (i < n)
    {
        i ++;
        if (i == (n))
        {
        pere = Math.Pow(i, 2);
        Console.Write($"{pere}");
        }
        else 
        {
        pere = Math.Pow(i, 2);
        Console.Write($"{pere}, "); 
        }
    }

}

Console.WriteLine("Введите число: ");
int chislo = int.Parse(Console.ReadLine());
N(chislo);
