// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


string N(int n)
{
   int n1 = 0;
   int n2 = 0;
   int n3 = 0;
   int n4 = 0;
    while (n < 100000)
    {
        if (n > 10000)
            if ((n1 = n / 10000) == (n2 = n % 10))
            {
                if ((n3 = n / 1000 % 10) == (n4 = n % 100 / 10))
                    return ($"Yes");
                else 
                    return ($"No");
            }
            else
                return ($"No");
        else
            return ($"error");        
    }
    return ($"error");
}

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
Console.Write(N(number));