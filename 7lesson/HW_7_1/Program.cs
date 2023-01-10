// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

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
 
void ValueElem(int[,] array, int i, int j)
{
    int n = array[i, j];

    if (i <= array.GetLength(0) & j <= array.GetLength(1))
    {
        n = array[i-1, j-1];
        Console.WriteLine($"Значение элемента: {n} ");
    }
    else    
        Console.WriteLine($"такого числа в массиве нет");
        
    
}

Console.Write("Enter the number of raws: ");
int raw = int.Parse(Console.ReadLine());
Console.Write("Enter the number of column: ");
int column = int.Parse(Console.ReadLine());

int[,] array_1 = Mass(raw, column,
                      int.Parse(Console.ReadLine()),
                      int.Parse(Console.ReadLine()));
Print(array_1);
ValueElem(array_1, 
          int.Parse(Console.ReadLine()),
          int.Parse(Console.ReadLine()));
