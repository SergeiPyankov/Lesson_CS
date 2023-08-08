//  Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0

int[] PrintRandomArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(-9, 10);
    Console.Write($"Случайно сгенерированный массив из {size} элеменетов => ");
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");
    return arr;
}

int SumNumber(int[] arr)
{
    int summa = 0;
    for (int i = 0; i < arr.Length; i += 2) summa += arr[i];
    return summa;
}

int[] array = PrintRandomArray(10);
System.Console.WriteLine($"Сумма чисел в массиве стоящих на нечётных местах равно => {SumNumber(array)}");
