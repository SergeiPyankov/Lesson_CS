// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int rows = InputInit("Введите количество строк => ");
int column = InputInit("Введите количество столбцов => ");
if (rows != column) 
{
    Console.WriteLine("число строк должно соответствовать количеству столбцов");
    Environment.Exit(1);
}
int maxNum = InputInit("Введите максимальное значение => ");
int[,] array = new int[rows, column];
FillArray(array, maxNum);
PrintArray(array); 
System.Console.WriteLine("Меняем строки с толбцы местами");
Result(array);


void Result(int[,] arr)
{
    int[,] resArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < resArr.GetLength(1); i++)
    {
        for (int j = 0; j < resArr.GetLength(0); j++)
        {
            resArr[i, j] = arr[j, i];
            System.Console.Write($"{resArr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int InputInit(string msg)
{
    Console.Write(msg);
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        if (value < 0)
        {
            System.Console.WriteLine("Вы ввели отрицательное значение");
            Environment.Exit(1);
        }
        if (value > 10)
        {
            System.Console.WriteLine("Введите число до 10");
            Environment.Exit(2);
        }
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(3);
    return 0;
}

void FillArray(int[,] inArray, int maxNum)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++) inArray[i, j] = new Random().Next(0, maxNum);
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) отвечает за длину строк
    {
        for (int j = 0; j < inArray.GetLength(1); j++) // GetLength(1) отвечает за длину столбцов
        {
            System.Console.Write($"{inArray[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
