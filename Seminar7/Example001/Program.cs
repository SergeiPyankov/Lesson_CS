// Задача 46: Задайте двумерный массив размером m × n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int m = InputInt("Введите 1-ое число");
int n = InputInt("Введите 2-ое число");

int[,] array = new int[m, n];

FillArray(m, n);

void FillArray(int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 9);
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int InputInt(string msg)
{
    System.Console.Write($"{msg}> ");
    if (int.TryParse(Console.ReadLine(), out int value)) return value;
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}