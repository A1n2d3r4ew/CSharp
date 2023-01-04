// Задайте массив заполненный случайными положительными
// трехзначными числами. Напишите программу, которая покажет
// количество четных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] Mass(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(99, 1000);
    return array;
}

void PrintArray(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]}, ");
    Console.WriteLine();
}

int Num(int[] array)
{
    int size = array.Length;
    int count = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    
    }
    return count;
}

int[] array = Mass(int.Parse(Console.ReadLine()));
PrintArray(array);
Console.WriteLine(Num(array));
