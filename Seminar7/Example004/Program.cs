// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] array = new int[5, 5];
FillArray();
System.Console.WriteLine();
int sum = ResultArr(array);
System.Console.WriteLine($"Сумма элементов массива равна => {sum}");

int ResultArr(int[,] array)
{
    int summa = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
            summa = summa + array[i, j];
            System.Console.Write($"{array[i, j]} ");
            }
            else System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
    return summa;
}

void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 8);
        }
    }
}