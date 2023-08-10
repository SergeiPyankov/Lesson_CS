// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int m = InputInt("Введите 1-ое число");
int n = InputInt("Введите 2-ое число");
int[,] array = FillArray(m, n);

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
    return array;
}

int InputInt(string msg)
{
    System.Console.Write($"{msg}> ");
    if (int.TryParse(Console.ReadLine(), out int value)) return value;
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}