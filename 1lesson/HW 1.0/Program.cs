
Console.WriteLine("Напишите первое число: ");

Console.WriteLine("Напишите второе число: ");

int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine(n1);
}
else if (n1 == n2)
{
    Console.WriteLine("ровнозначные");
}
else
    Console.WriteLine(n2);