﻿// Шаблоны методов

// Ввод значений

Console.Write("Введите первое число ");
string inputValue1 = Console.ReadLine();
int value1 = Convert.ToInt32(inputValue1);

// Ввод пользовательских значений

int InputInt(string msg)
{
    System.Console.Write($"{msg}> ");
    if (int.TryParse(Console.ReadLine(), out int value)) return value;
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1); 
    return 0;
}

// Ввод пользовательских значений с допоплнительным условием

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
        if (value > 100)
        {
            System.Console.WriteLine("Введите число до 100");
            Environment.Exit(2);
        }
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(3);
    return 0;
}

// Цикличный ввод пользовательских значений 

int Prompt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int val = 0;
    while ((int.TryParse(value, out val)) != true)
    {
        Console.Write("Неверный ввод. Повторите => ");
        value = Console.ReadLine();
    }
    return val;
}

// Создание и заполниение массива случайными числами

int[] FillArray(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0, 10);
        return arr;
    }

// Заполнение многомерного массива уникальными значениями

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

// Создание и вывод массива из случайных чисел

int[] PrintRandomArray(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0, 10);
        Console.WriteLine($"Случайно сгенерированный массив из {size} элеменетов => ");
        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");
        return arr;
    }

// Вывод массива на экран

void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
    }

// Заполниение многомерного массива случайными числами

void FillArray(int[,] inArray, int maxNum)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++) inArray[i, j] = new Random().Next(0, maxNum);
    }
}
// Создание и вывод многомерного массива из случайных чисел

void PrintRandomArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) отвечает за длину строк
    {
        for (int j = 0; j < inArray.GetLength(1); j++) // GetLength(1) отвечает за длину столбцов
        {
            inArray[i, j] = new Random().Next(0, 9);
            System.Console.Write($"{inArray[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

// Вывод многомерного массива на экран

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

// Поиск второго максимального

int SecondMax(int[] arr)
{
    int smax = 0, max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            smax = max;
            max = arr[i];
            //System.Console.WriteLine($"{arr[i]} max = {max}, smax = {smax}");
        }
        else
        {
            if (smax < arr[i])
            {
                smax = arr[i];
            }
            //System.Console.WriteLine($"{arr[i]} нет входа max = {max}, smax = {smax}");
        }
    }
    return smax;
}

// поиск конкретного значения в массиве

string SearchUserNum(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        return "Yes";
    }
    return "No";
}

// смена положительных и отрицательных значений массива (с + на - ; с - на +)

int[] PrintReverseNumArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++) arr[i] *= -1;
        Console.WriteLine($"Инверсия массива => ");
        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");
        return arr;
    }

// Перемножение первых и последних чисел массива

int[] CompositionNumArray(int[] arr)
{
    if (arr.Length % 2 == 0)
    {
        int[] compArr = new int[arr.Length / 2];
        for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--) compArr[i] = arr[i] * arr[j];
        return compArr;
    }
    else
    {
        int[] compArr = new int[arr.Length / 2 + 1];
        for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--) compArr[i] = arr[i] * arr[j];
        compArr[^1] = arr[arr.Length / 2];
        return compArr;
    }
}

// Поиск двузначных чисел

int SearchTwoDigits(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++) if (arr[i] > 9 && arr[i] < 100) count++;
    return count;
}

// Факториал

double Factorial(int val)
{
    double count = 1;
    for (int i = 1; i <= val; i++)
    {
        count *= i;
        System.Console.WriteLine(count);
    }
        return count;
}

