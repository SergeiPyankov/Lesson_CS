// Задача 62: Заполните спирально массив 4 на 4.

int size = 5;
int[,] array = new int[size, size];
SpiralFillArray(array, size);
PrintArray(array);

void SpiralFillArray(int[,] array, int size)
{
    int value = 1;
    int i = 0;
    int j = 0;
    while (value <= size * size)
    {
        array[i, j] = value;
        if (i <= j + 1 && i + j < size - 1) j++;
        else if (i < j && i + j >= size - 1) i++;
        else if (i >= j && i + j > size - 1) j--;
        else i--;
        value++;
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