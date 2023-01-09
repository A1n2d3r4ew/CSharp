// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько
// чисел больше 0 ввел пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

int Num()
{
    int result = 0;
    string s;

    while (true)
    {
        Console.Write("Press number: ");
        s = Console.ReadLine();

        if (s == "")
            return result;
        else if (int.Parse(s) > 0) 
            result += 1;
    
    }
    
}


Console.Write(Num());