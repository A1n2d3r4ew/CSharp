// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.


// int[] PairsNum(int[] arr)
//{
//int size = arr.Length;
//int flex_size = size / 2 + size % 2;
//int[] new_arr = new int[flex_size];

//for (int i = 0; i < size / 2; i++)
//new_arr[i] = arr[i] * arr[size - i - 1];

//if (new_arr[flex_size - 1] == 0)
//new_arr[flex_size - 1] = arr[flex_size - 1];
//return new_arr;
//}

// Ссылки для вещественных чисел (ДЗ)
// https://docs.microsoft.com/en-us/dotnet/api/system.random.nextdouble?view=net-6.0
// https://ru.stackoverflow.com/questions/1254105/%D0%9A%D0%B0%D0%BA-%D1%81%D0%B3%D0%B5%D0%BD%D0%B5%D1%80%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D1%82%D1%8C-%D1%81%D0%BB%D1%83%D1%87%D0%B0%D0%B9%D0%BD%D0%BE%D0%B5-%D0%B4%D1%80%D0%BE%D0%B1%D0%BD%D0%BE%D0%B5-%D1%87%D0%B8%D1%81%D0%BB%D0%BE-%D0%B8%D0%B7-%D0%B8%D0%BD%D1%82%D0%B5%D1%80%D0%B2%D0%B0%D0%BB%D0%B0

int[] Mass(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 10);
    return array;
}

void PrintArray(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]}, ");
    Console.WriteLine();
}

int[] PairsNum(int[] arr)
{
int size = arr.Length;
int flex_size = size / 2 + size % 2;
int[] new_arr = new int[flex_size];

for (int i = 0; i < size / 2; i++)
new_arr[i] = arr[i] * arr[size - i - 1];

if (new_arr[flex_size - 1] == 0)
new_arr[flex_size - 1] = arr[flex_size - 1];
return new_arr;
}

int[] arr_1 = Mass(5);
PrintArray(arr_1);
int[] arr_1_new = PairsNum(arr_1);
PrintArray(arr_1_new);
