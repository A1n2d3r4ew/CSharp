// Задайте дномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых
// лежат в отрезке [10,99]

void PrintArray(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size ; i ++)
        Console.Write($"{array[i]}, ");
    Console.WriteLine();
}

int[] Mass(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 124);
    return array;
}

int Num(int[] array)
{
    int count = 0;
    int size = array.Length; 
    for (int i = 0; i < size; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
                count++;
        }
    }
    return count;
}

int[] array = Mass(int.Parse(Console.ReadLine()));
PrintArray(array);
Console.WriteLine(Num(array));
