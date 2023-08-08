// Задача 4: Задайте одномерный массив из 10 случайных чисел в диапазоне от 1 до 200. Найдите количество двузначных элементов массива. 
// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] PrintRandomArray()
{
    int[] arr = new int[10];
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(1, 201);
    Console.Write($"Случайно сгенерированный массив из 10 элементов от 1 до 200: ");
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");
    System.Console.WriteLine();
    return arr;
}

int SearchTwoDigits(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++) if (arr[i] > 9 && arr[i] < 100) count++;
    return count;
}

int[] array = PrintRandomArray();
System.Console.Write($"Количество двузначных чисел в массиве: {SearchTwoDigits(array)}");