// Задайте двумерный массив размера m на n, каждый элемент
// в массиве находится по формуле: А  = m + n.
// Выыедите получанный массив на экран.

// m = 3, n = 4.
// 0123
// 1234
// 2345

int[,] Mass(int raw, int column)
{
    int[,] array = new int[raw, column];

    for (int i = 0; i < raw; i++)
        for (int j = 0; j < column; j++)
            array[i, j] = i + j;

    return array;
}

void PrintArray(int[,] array)
{
    int column_size = array.GetLength(1);
    int raw_size = array.GetLength(0);

    for (int i = 0; i < raw_size; i++)
    {    
        for (int j = 0; j < column_size; j++)
            Console.Write($"{array[i,j], 4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter the number of raws: ");
int raw = int.Parse(Console.ReadLine());
Console.Write("Enter the number of column: ");
int column = int.Parse(Console.ReadLine());

int[,] array_1 = Mass(raw, column);
                     
PrintArray(array_1);