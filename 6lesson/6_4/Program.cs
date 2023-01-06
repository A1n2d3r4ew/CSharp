// Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

int[,] Mass(int raw, int stolb)
{
    int[,] array = new int[raw, stolb];

        for (int i = 0; i < raw; i++)
            for (int j = 0; j < stolb; j++)
                array[i, j] = new Random().Next(-50, 50);
    return array;
}

void PrintArray(int[,] array)
{
    int stolb = array.GetLength(1);
    int raw = array.GetLength(0);

    for (int i = 0; i < raw; i++)
    {    
        for (int j = 0; j < stolb; j++)
            Console.Write($"{array[i,j]}, ");
        Console.WriteLine();
    }
}

int[,] Clone(int[,] array)
{
    int stolb = array.GetLength(1);
    int raw = array.GetLength(0);
    int[,] new_array = new int[raw, stolb];

    for (int i = 0; i < raw; i++)
    {    
        for (int j = 0; j < stolb; j++)
            new_array[i, j] = array[i, j];
    }
    return new_array;
}

int[,] array_1 = Mass(
    int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()));
PrintArray(array_1);
int[,] array_2 = Clone(array_1);
Console.WriteLine();
PrintArray(array_2);