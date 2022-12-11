//Напишите программу, которая принимает на вход число и
//проверяет, кратно ли оно одновременно 7 и 23.

string Num(int n)
{
    if (n % 7 == 0 && n % 23 == 0)
        return ("Кратно 7 и 23");
    else 
        return ($"не кратно 7 и 23");
}

Console.Write($"Введите число:  ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Num(num));

 