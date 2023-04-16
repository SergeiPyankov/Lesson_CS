// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] PrintRandomArray()
{
    int[] arr = new int[12];
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(-9, 10);
    Console.Write($"Случайно сгенерированный массив от -9 до 9 => ");
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");
    return arr;
}

void SumPositiveNegative(int[] arr, out int pos, out int neg)
{
    pos = 0;
    neg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) {pos = pos + arr[i];}
        else {neg = neg + arr[i];}
    }
}

int[] array = PrintRandomArray();
SumPositiveNegative(array, out int positive, out int negative);
System.Console.Write($"Сумма положительных значений массива равна {positive}, Сумма отрицательных значений массива равна {negative}");
