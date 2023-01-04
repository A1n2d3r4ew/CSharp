// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.

// [3, 7, 22, 2, 78] -> 76

// Ссылки для вещественных чисел (ДЗ)
// https://docs.microsoft.com/en-us/dotnet/api/system.random.nextdouble?view=net-6.0
// https://ru.stackoverflow.com/questions/1254105/%D0%9A%D0%B0%D0%BA-%D1%81%D0%B3%D0%B5%D0%BD%D0%B5%D1%80%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D1%82%D1%8C-%D1%81%D0%BB%D1%83%D1%87%D0%B0%D0%B9%D0%BD%D0%BE%D0%B5-%D0%B4%D1%80%D0%BE%D0%B1%D0%BD%D0%BE%D0%B5-%D1%87%D0%B8%D1%81%D0%BB%D0%BE-%D0%B8%D0%B7-%D0%B8%D0%BD%D1%82%D0%B5%D1%80%D0%B2%D0%B0%D0%BB%D0%B0

int[] Mass(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().NextDouble(-10, 10);
    return array;
}

void PrintArray(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]}, ");
    Console.WriteLine();
}

int Div(int[] array)
{
    int max = 0;
    int min = 0;
    int div = 0;

    for (int i = 0; i <= array.Length; i++)
    {
        if (i > max)
            max = max + i;
        else  
            min = min + i;   
    }

    return div = max - min;
}

int[] array = Mass(int.Parse(Console.ReadLine()));
PrintArray(array);
Console.WriteLine(Div(array));