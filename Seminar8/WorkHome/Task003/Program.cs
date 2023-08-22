// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int rows = InputInit("Введите количество строк => ");
int column = rows; //InputInit("Введите количество столбцов => ");
int maxNum = InputInit("Введите максимальное значение => ");
int[,] matrix1 = new int[rows, column];
int[,] matrix2 = new int[rows, column];
FillArray(matrix1, maxNum);
FillArray(matrix2, maxNum);
PrintArray(matrix1);
System.Console.WriteLine();
PrintArray(matrix2);
System.Console.WriteLine();
int[,] mxm = ProductMatrix(matrix1, matrix2);
PrintArray(mxm);

int[,] ProductMatrix(int[,] arr1, int[,] arr2)
{
    int x = arr1.GetLength(0);
    int y = arr2.GetLength(1);
    int[,] array = new int[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                array[i, j] += arr1[i, k] * arr2[k, j];
            }
            System.Console.WriteLine($"Строка {i} Столбец {j} Результат {array[i, j]}");

        }
    }
    return array;
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
        if (value > 101)
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
        for (int j = 0; j < inArray.GetLength(1); j++) inArray[i, j] = new Random().Next(1, maxNum + 1);
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