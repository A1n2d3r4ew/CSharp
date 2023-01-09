// Задайте двумерный массив. Найдите элементы, у которых
// обе позиции четные, и замените эти элементы на их квадраты.

// 1 4 7 2       1 4 7 2
// 5 9 2 3       5 81 2 9
// 8 4 2 4       8 4 2 4 

int[,] Mass(int row, int column, int from, int to)
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            array[i, j] = new Random().Next(from, to);

    return array; 
}

void Print(int[,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {array[i,j], 4} ");
            Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(int[,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);

    for (int i = 1; i < row_size; i += 2)
    
        for (int j = 1; j < column_size; j += 2)
           
    array [i, j] *= array [i, j];
    
}

Console.Write("Enter the number of raws: ");
int raw = int.Parse(Console.ReadLine());
Console.Write("Enter the number of column: ");
int column = int.Parse(Console.ReadLine());

int[,] array_1 = Mass(raw, column,
                      int.Parse(Console.ReadLine()),
                      int.Parse(Console.ReadLine()));
Print(array_1);
PrintArray(array_1);
Print(array_1);