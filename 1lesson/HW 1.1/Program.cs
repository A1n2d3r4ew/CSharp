
Console.WriteLine("Введите число: ");
string A = Console.ReadLine();
int max = int.Parse(A);
Console.WriteLine("Введите число: ");
string B = Console.ReadLine();
int N = int.Parse(B);
Console.WriteLine("Введите число: ");
string C = Console.ReadLine();
int N_1 = int.Parse(C);

if (max > N)
{
    if (max > N_1)
    Console.WriteLine(max);
}
else if (N > N_1)
{
    Console.WriteLine(N);
}
else 
    Console.WriteLine(N_1);