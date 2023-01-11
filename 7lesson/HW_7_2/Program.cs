// Задайте двумерный массив из целых чисел.Найдите среднее арифметическое
// элементов в каждом столбце.

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void Average(int[,] array)
{
    
    double aver_result;
    int row = array.GetLength(0);
    int columns = array.GetLength(1);
    
    for (int i = 0; i < columns; i++)
    {
        aver_result = 0;
        for (int j = 0; j < row; j ++)
        aver_result += array[j, i];
        Console.Write($"{Math.Round(aver_result / row, 2)}; ");
    }
    
}       


Console.Write("Enter the number of raws: ");
int raw = int.Parse(Console.ReadLine());
Console.Write("Enter the number of column: ");
int column = int.Parse(Console.ReadLine());

int[,] array_1 = Mass(raw, column,
                      int.Parse(Console.ReadLine()),
                      int.Parse(Console.ReadLine()));
Print(array_1);
Average(array_1);