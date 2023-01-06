// Напишите программу которая перевернет одномерный массив
// (пследний элемент будет на первом месте, а первый - на
// последнем и т.д)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] Mass(int size, int from, int to)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(from, to);
    return array;
}

void PrintArray(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]}, ");
    Console.WriteLine();
}

void RevMass(int[] array_1)
{
    
    int size = array_1.Length;

    for (int i = 0; i < size / 2; i++)
        (array_1[i], array_1[size - i - 1]) = (array_1[size - i - 1], array_1[i]);
        // картеж
}


int[] array_1 = Mass(
    int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()));
PrintArray(array_1);
RevMass(array_1);
PrintArray(array_1);