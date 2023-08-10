// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array = new int[10,10]; 
PrintArray(array);
int userNum = InputInit("Введитеп число от 0 до 99");
int x = 0;
int y = 0;
FindIndex(userNum, out x, out y);
System.Console.WriteLine($"Элемент массива строка {x} и столбец {y} равен => {array[x, y]}");


void FindIndex(int num, out int x, out int y)
{
    if (num > 9)
    {
        y = num % 10;
        x = num / 10;
    }
    else
    {
        x = 0;
        y = num;
    }
}

int InputInit(string msg)
{
    Console.WriteLine(msg);
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        if (value < 0)
        {
            System.Console.WriteLine("Вы ввели отрицательное значение");
            Environment.Exit(1);
        }
        if (value > 99)
        {
            System.Console.WriteLine("Такого числа нет в массиве");
            Environment.Exit(2);
        }
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(3);
    return 0;
}

void PrintArray(int[,] inArray)

{
    for (int i = 0; i < inArray.GetLength(0); i++) 
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            inArray[i, j] = new Random().Next(0, 9);
            System.Console.Write($"{inArray[i, j]} ");
        }
        System.Console.WriteLine();
    }
}