// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (х и у).

void Quar(string a)
{
    if (a == "I")
        Console.WriteLine("x > 0 and y > 0");
    else if (a == "II")
        Console.WriteLine("x < 0 and y > 0");
    else if (a == "III")
        Console.WriteLine("x < 0 and y < 0");
    else if (a == "IV")
        Console.WriteLine("x > 0 and y < 0");
    else 
        Console.WriteLine("error");
}

Quar(Console.ReadLine());