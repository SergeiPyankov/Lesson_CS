// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] array = new int[10];
for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 10);
Console.Write($"Случайно сгенерированный массив от 0 до 9 => ");
for (int i = 0; i < array.Length; i++) Console.Write(array[i] + ", ");
System.Console.WriteLine();

int[] copyArr = new int[array.Length];
for (int i = 0; i < array.Length; i++) copyArr[i] = array[i];
Console.Write($" Копия сгенерированного массива от 0 до 9 => ");
for (int i = 0; i < array.Length; i++) Console.Write(array[i] + ", ");