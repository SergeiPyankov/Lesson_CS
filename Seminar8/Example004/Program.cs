// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


int rows = InputInit("Введите количество строк => ");
int column = InputInit("Введите количество столбцов => ");
int maxNum = InputInit("Введите максимальное значение => ");
int[,] array = new int[rows, column];
FillArray(array, maxNum);
PrintArray(array);
System.Console.WriteLine();
int x = 0;
int y = 0;
int minNumber = SearchMin(array, ref x, ref y);
System.Console.WriteLine("Наименьшее число в массиве " + minNumber);
System.Console.WriteLine($"Строка {x + 1} Ряд {y + 1}");
System.Console.WriteLine();
int[,] resultArray = ResultArr(array, x, y);
PrintArray(resultArray);

int SearchMin(int[,] arr, ref int x, ref int y)
{
    int minNum = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (minNum > arr[i, j])
            {
                minNum = arr[i, j];
                x = i;
                y = j;
            }
        }
    }
    return minNum;
}

int[,] ResultArr(int[,] arr, int x, int y)
{
    int[,] array = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0, ii = 0; i < arr.GetLength(0); i++, ii++)
    {
        if (i != x)
        {
            for (int j = 0, jj = 0; j < arr.GetLength(1); j++, jj++)
            {
                if (j != y) array[ii, jj] = arr[i, j];
                else jj -= 1;
            }
        }
        else ii -= 1;
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
