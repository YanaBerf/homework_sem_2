﻿Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

if (a == b * b || b == a * a)
{
    Console.WriteLine($"{a}, {b} -> да");
}
else
{
    Console.WriteLine($"{a}, {b} -> нет");
}