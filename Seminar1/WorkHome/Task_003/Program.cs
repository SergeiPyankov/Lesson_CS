﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число "); 
string inputValue = Console.ReadLine();
int number = Convert.ToInt32(inputValue);

if (number % 2 == 0)
{
    System.Console.WriteLine("Число является четным");
}
else
{
    System.Console.WriteLine("Число является нечетным");
}
