// Напишите программу, которая принимает на вход число 
// и выдает кол-во цифр в числе

// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Num(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count ++;
    }
    return count;

}

Console.WriteLine(Num(456));
 
