// Задача 47: Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] array = new double[3, 4];
array = PrintArray(array);

double[,] PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) отвечает за длину строк
    {
        for (int j = 0; j < inArray.GetLength(1); j++) // GetLength(1) отвечает за длину столбцов
        {
            inArray[i, j] = new Random().Next(-9, 10) * new Random().NextDouble();
            // Random rnd = new Random();
            // inArray[i, j] = (rnd.NextDouble() * (100 - (-100)) + (-100),2);
            System.Console.Write($"{Math.Round(inArray[i, j], 1)} ");
        }
        System.Console.WriteLine();
    }
    return inArray;
}

