// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным

string N(int n)
{
    if (n > 5)
        return $"Выходной";
    else
        return $"Не выходной";
}



Console.WriteLine("Напишите цифру:  ");
int w = int.Parse(Console.ReadLine());
Console.WriteLine(N(w));