// Не спользуя рекурсию, выведите первые N чисел
// Фибоначчи. Прервые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 01123
// Если N = 3 -> 011
// Если N = 7 -> 0112358

void Fib(int num)
{
    int n1 = 0;
    int n2 = 1;
    
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{n1} ");
        (n1, n2) = (n2, n1 + n2);

    } 
}

Fib(int.Parse(Console.ReadLine()));