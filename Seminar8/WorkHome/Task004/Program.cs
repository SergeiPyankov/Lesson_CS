// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int x = 3; // InputInit("Введите количество строк => ");
int y = 3;
int z = 3; // InputInit("Введите количество столбцов => ");
int maxNum = InputInit("Введите максимальное значение => ");
int[,,] array3D = new int[x, y, z];
FillArray(array3D, maxNum);
PrintArray(array3D);



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

void FillArray(int[,,] inArray, int maxNum)
{

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int h = 0; h < inArray.GetLength(2); h++)
            {
                for (int k = 1; k >= 1; k++)
                {
                    int num = new Random().Next(1, maxNum + 1);
                    if (CheckArr(inArray, num))
                    {
                        inArray[i, j, h] = num;
                        System.Console.WriteLine(k);
                        break;
                    }
                }
            }
        }
    }
}

bool CheckArr(int[,,] arr, int num)
{
    foreach (int i in arr)
    {
        if (i == num) return false;
    }
    return true;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) отвечает за длину строк
    {
        for (int h = 0; h < inArray.GetLength(2); h++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++) // GetLength(1) отвечает за длину столбцов
            {
                Console.Write($"{inArray[i, j, h]} ({i} {j} {h}) ");
            }
        }
        Console.WriteLine();
    }
}

// Альтернативный метод

void ExclusiveRandomArray(int[] array, int min, int max);
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        if (i >= 1)
        {
            for (int j = 0; j < array.Length; j++)
            {
                while (array[i] == array[j])
                {
                    array[i] = new Random().Next(min, max + 1);
                    j = 0;

                }
            }
        }
    }
}