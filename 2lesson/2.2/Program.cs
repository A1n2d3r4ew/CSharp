

string Num(int num, int num2)
{
    if (num % num2 == 0)
        return "кратно";
    else
        return $"некратно, остаток = {num % num2}";
}
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine(Num(n, n2));
