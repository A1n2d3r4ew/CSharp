// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие
// отртицательные, и наоборот.
// [-4,-8,8,2]->[4,8,-8,-2]

void PrintArray(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size ; i ++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] Mass(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-10, 10);
    return array;
}

void Massiv(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
        array[i] = -array[i];
           
} 

int[] array = Mass(int.Parse(Console.ReadLine()));
PrintArray(array);
Massiv(array);
PrintArray(array);

