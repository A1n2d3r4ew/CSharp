// Задайте одномерный массив, заполненный случайными
// числами.Найдите скмму элементов, стоящих на нечетных позициях.

// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0

int[] Mass(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-50, 50);
    return array;
}

void PrintArray(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]}, ");
    Console.WriteLine();
}

int Sum(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i = i + 2)
        count = count + array[i];
    return count;
}

int[] array = Mass(int.Parse(Console.ReadLine()));
PrintArray(array);
Console.WriteLine(Sum(array));