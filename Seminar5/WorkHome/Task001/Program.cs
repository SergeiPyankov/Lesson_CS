// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] PrintRandomArray(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(100, 1000);
        Console.Write($"Случайно сгенерированный массив из {size} элеменетов => ");
        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");
        return arr;
    }

int EvenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++) if (arr[i] % 2 == 0) count++;
    return count;
}

int[] array = PrintRandomArray(10);
System.Console.WriteLine($"Количество четных чисел в массиве равно => {EvenNumber(array)}");
