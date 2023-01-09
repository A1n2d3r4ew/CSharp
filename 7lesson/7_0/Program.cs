// Задайте двумерный массив размером m x n, 
// заполненный случайными числами.




int[,] Mass(int raw, int column, int from, int to)
{
    int[,] array = new int[raw, column];

    for (int i = 0; i < raw; i++)
        for (int j = 0; j < column; j++)
            array[i, j] = new Random().Next(from, to);

    return array;
}

void PrintArray(int[,] array)
{
    int column_size = array.GetLength(1);
    int raw_size = array.GetLength(0);

    for (int i = 0; i < raw_size; i++)
    {    
        for (int j = 1; j < column_size; j++)
            Console.Write($"{array[i,j], 4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter the number of raws: ");
int raw = int.Parse(Console.ReadLine());
Console.Write("Enter the number of column: ");
int column = int.Parse(Console.ReadLine());

int[,] array_1 = Mass(raw, column,
                      int.Parse(Console.ReadLine()),
                      int.Parse(Console.ReadLine()));
PrintArray(array_1);



