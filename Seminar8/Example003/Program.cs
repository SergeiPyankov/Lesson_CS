// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных                 Набор данных
// { 1, 9, 9, 0, 2, 8, 0, 9 }   1, 2, 3
//                              4, 6, 1
//                              2, 1, 6
// Частотный массив             Частотный массив 
// 0 встречается 2 раза         1 встречается 3 раза
// 1 встречается 1 раз          2 встречается 2 раз
// 2 встречается 1 раз          3 встречается 1 раз
// 8 встречается 1 раз          4 встречается 1 раз
// 9 встречается 3 раза         6 встречается 2 раза


int rows = InputInit("Введите количество строк => ");
int column = InputInit("Введите количество столбцов => ");
int maxNum = InputInit("Введите максимальное значение => ");
int[,] array = new int[rows, column];
FillArray(array, maxNum);
PrintArray(array);
System.Console.WriteLine("Частотный календарь");
int[] x = SumNum(array);
CalendarNum(x);

void CalendarNum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    if (arr[i] != 0) Console.WriteLine($"{i} встречается {arr[i]} раз");
}

int[] SumNum(int[,] arr)
{
    int[] x = new int[arr.Length];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            x[arr[i, j]] += 1;
        }
    }
    return x;
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
        for (int j = 0; j < inArray.GetLength(1); j++) inArray[i, j] = new Random().Next(0, maxNum + 1);
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
