// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.

// [3, 7, 22, 2, 78] -> 76

// Ссылки для вещественных чисел (ДЗ)
// https://docs.microsoft.com/en-us/dotnet/api/system.random.nextdouble?view=net-6.0
// https://ru.stackoverflow.com/questions/1254105/%D0%9A%D0%B0%D0%BA-%D1%81%D0%B3%D0%B5%D0%BD%D0%B5%D1%80%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D1%82%D1%8C-%D1%81%D0%BB%D1%83%D1%87%D0%B0%D0%B9%D0%BD%D0%BE%D0%B5-%D0%B4%D1%80%D0%BE%D0%B1%D0%BD%D0%BE%D0%B5-%D1%87%D0%B8%D1%81%D0%BB%D0%BE-%D0%B8%D0%B7-%D0%B8%D0%BD%D1%82%D0%B5%D1%80%D0%B2%D0%B0%D0%BB%D0%B0

double[] Mass(int size, int from, int to)
{
    double[] array = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
        array[i] = Math.Round(n_new.NextDouble() * (from + to) - from, 2);

    return array;
}

void PrintArray(double[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]}, ");
    Console.WriteLine();
}

void Dif(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];

        else if (min > array[i])
            min = array[i];
    }

    Console.Write($"Max: {max}, Min: {min}. ");
    Console.WriteLine($"Difference: {max} - ({min}) = {Math.Round(max - min, 2)}");
}

double[] array = Mass(
    int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()));
PrintArray(array);
Dif(array);
