
Console.WriteLine("Write a numb: ");
string A = Console.ReadLine();
int N = int.Parse(A);
int NegN = - N;

while(NegN <= N)
{
    Console.WriteLine($"{NegN} ");
    NegN +=1;
}