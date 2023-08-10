// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


int m = InputInt("Введите 1-ое число");
int n = InputInt("Введите 2-ое число");
int min = InputInt("Введите минимальное значение");
int max = InputInt("Введите максимальное значение");
System.Console.WriteLine($"Двумерный массив {m} х {n} элементов с числами от {min} до {max}");

int[,] array = new int[m, n];
FillArray(m, n);
System.Console.WriteLine();
QuadArray(array);


void QuadArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
            array[i, j] = array[i, j] * array[i, j];
            System.Console.Write($"{array[i, j]} ");
            }
            else System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max);
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