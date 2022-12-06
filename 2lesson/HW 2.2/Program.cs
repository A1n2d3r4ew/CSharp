// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//  N( int[] n = {} )
{
    if (int[] n > 2)
    {
        n = n / 10;
        n = n % 10;
        return $"{n}";
    }
    else 
        return "третьей цифры нет";
    
}

Console.WriteLine("Введите число");
int[] a = {int.Parse(Console.ReadLine())};
Console.WriteLine(N(int[] a));