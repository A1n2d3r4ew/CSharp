// Задайте двумерный массив размером m x n, заполненный случайными
// вещественными числами.

// m = 3, n = 4.
// 0,5  7  -2  -0,2
// 1  -3,3  8  -9,9
// 8  7,8  -7,1  9

double[,] Mass(int row, int column, int from, int to)
{
    double[,] array = new double[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            array[i, j] = Math.Round(new Random().NextDouble() * (from + to) - from, 2);

    return array; 
}

void Print(double[,] array)
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

Console.Write("Enter the number of raws: ");
int raw = int.Parse(Console.ReadLine());
Console.Write("Enter the number of column: ");
int column = int.Parse(Console.ReadLine());

double[,] array_1 = Mass(raw, column,
                      int.Parse(Console.ReadLine()),
                      int.Parse(Console.ReadLine()));
Print(array_1);

