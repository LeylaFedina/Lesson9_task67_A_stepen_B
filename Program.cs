﻿/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8

*/

int printRange(int A, int B)
{
    int result = 0;
    if (B == 0)
    {
        return 1;
    }
    return A * printRange(A, B - 1);
}

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = printRange(A, B);
Console.WriteLine(result);
