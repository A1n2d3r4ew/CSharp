//Напишите программу, которая принимает на вход трехзначное 
//число и на выходе показывает вторую цифру этого числа




string N(int num);
{
int count = 1000;
int max = num;
while(max < count)
{
    if (num % 10 == num / 10)
        return ($"Вторая цифра числа: {num}");
    else
        return ($"Ошибка");
}

}

Console.WriteLine("Напишите трехзначное число:  ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(N(n));