﻿// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

System.Console.Write("Введите число от 100> ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100)
{
    num = num / 100;
    System.Console.WriteLine($"Третья цифра заданного числа {num % 10}"); 
}
else
{
    System.Console.WriteLine("Вы ввели число меньше 100");
}