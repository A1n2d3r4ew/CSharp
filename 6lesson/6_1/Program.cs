﻿// Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами
// такой длины.

void Try(int a, int b, int c)
{
    if (a < b + c & b < a + c & c < a + b)
        Console.WriteLine($"Yes");
    else
        Console.WriteLine($"No");

}

Try(int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()));
