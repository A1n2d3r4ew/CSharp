//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int Number(string mes)
{
    Console.Write(mes);
    int s = int.Parse(Console.ReadLine());
    return s;
}

double R(int ax, int ay, int bx, int by, int az, int bz)
{
    double a = Math.Sqrt(Math.Pow(bx-ax,2)+Math.Pow(by-ay,2)+Math.Pow(bz-az,2));
    return a; 
}

int ax = Number("Введите ax: ");
int ay = Number("Введите ay: ");
int az = Number("Введите az: ");
int bx = Number("Введите bx: ");
int by = Number("Введите by: ");
int bz = Number("Введите bz: ");

Console.WriteLine(Math.Round(R(ax, ay, bx, by, az, bz),2));