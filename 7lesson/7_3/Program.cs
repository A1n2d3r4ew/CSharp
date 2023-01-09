// Задайте двумерный массив. Найдите сумму элементов 
// главной диагонали.
 
// 1 4 7
// 5 9 2
// 8 4 2

// Сумм = 1+9+2=12
// https://4apple.org/summa-diagonalnyh-jelementov-matricy/
// https://ru.wikipedia.org/wiki/%D0%93%D0%BB%D0%B0%D0%B2%D0%BD%D0%B0%D1%8F_%D0%B4%D0%B8%D0%B0%D0%B3%D0%BE%D0%BD%D0%B0%D0%BB%D1%8C

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

int Sum(int[,] array)
{
    int sum = 0;
    int row = array.GetLength(0);

    for (int i = 0; i < row; i++)
        sum += array[i, i];
    
    return sum;
}

Console.Write("Enter the number of raws: ");
int raw = int.Parse(Console.ReadLine());
Console.Write("Enter the number of column: ");
int column = int.Parse(Console.ReadLine());

int[,] array_1 = Mass(raw, column,
                      int.Parse(Console.ReadLine()),
                      int.Parse(Console.ReadLine()));
Print(array_1);
Console.WriteLine(Sum(array_1));