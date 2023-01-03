// Задайте массив. Напишите прогпамму, которая определяет,
// присутствует ли заданное число в массиве.

void PrintArray(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size ; i ++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] Mass(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-10, 10);
    return array;
}

void Num(int[] array, int n)
{
    int size = array.Length;
    for(int i = 0; i < size; i++)
    {
        if (n == array[i])
        {
            Console.WriteLine("Yes");
            return;
        }
        else
        {    
            Console.WriteLine("No");
            return;
        }
    }
}

int[] array = Mass(int.Parse(Console.ReadLine()));
PrintArray(array);
Console.WriteLine("Number  ");
Num(array, int.Parse(Console.ReadLine()));
