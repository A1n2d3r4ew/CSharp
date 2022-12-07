// Напишите программу, уоторая принимает на вход 
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// А(3,6);В(2,1) -> 5,09
// А(7,-5);В(1,-1) -> 7,21

int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

double Dis(int ax, int ay, int bx, int by)
{
    double result;
    result = Math.Sqrt(Math.Pow(bx-ax,2)+Math.Pow(by-ay,2));
    return result;
}

int ax = ReadNumber("Введите aХ: ");
int ay = ReadNumber("Введите aY: ");
int bx = ReadNumber("Введите bХ: ");
int by = ReadNumber("Введите bY: ");

Console.WriteLine(Math.Round(Dis(ax, ay, bx, by),2));