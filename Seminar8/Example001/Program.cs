// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int sizeArray = InputInit("Введите размер массива => ");
int maxNum = InputInit("Введите максимальное значение => ");
int[,] array = new int[sizeArray, sizeArray];
FillArray(array, maxNum);
PrintArray(array); 
System.Console.WriteLine("Меняем первую и последнюю строку местами");
array = Result(array);
PrintArray(array);


int[,] Result(int[,] arr)
{
    int[] tmpArr = new int[arr.GetLength(1)];
    for (int i = 0; i < tmpArr.Length; i++) tmpArr[i] = arr[0, i];
    for (int i = 0; i < arr.GetLength(1); i++) 
    {
        arr[0, i] = arr[arr.GetLength(1) - 1, i];
        arr[arr.GetLength(0) - 1, i] = tmpArr[i];
    }
    return arr;
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