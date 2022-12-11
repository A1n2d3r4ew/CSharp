//Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого числа.


string N(int num)
{
    Console.WriteLine(num);

    int n1 = num / 100;
    int n2 = num % 10;
    return  $"{n1}{n2}";
}

Console.WriteLine(N(new Random().Next(99, 1000)));