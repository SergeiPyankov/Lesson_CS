// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.


int sizeArray = InputInit("Введите размер массива => ");
int maxNum = InputInit("Введите максимальное значение => ");
int[,] array = new int[sizeArray, sizeArray];
PrintArray(array, maxNum);
Result(array);


void Result(int[,] inArray)
{
    double average = 0;
    for (int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) отвечает за длину строк
    {
        for (int j = 0; j < inArray.GetLength(1); j++) // GetLength(1) отвечает за длину столбцов 
        {
            average += inArray[j, i];
        }
        Console.WriteLine($"Среднее арифметическое столбца {i + 1} равно => {Math.Round(average / inArray.GetLength(0), 2)}");
        average = 0;
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

void PrintArray(int[,] inArray, int maxNum)
{
    for (int i = 0; i < inArray.GetLength(0); i++) 
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            inArray[i, j] = new Random().Next(0, maxNum);
            System.Console.Write($"{inArray[i, j]} ");
        }
        System.Console.WriteLine();
    }
}