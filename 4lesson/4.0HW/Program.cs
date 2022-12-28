//  Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int A(int a, int b)
{
    int result = 1;

    for(int i = 1; i <= b; i++)
        result = result * a;
    return result;
}

Console.WriteLine("Введите число А: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write(A(n, n1));