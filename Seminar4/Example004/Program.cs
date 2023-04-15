// Задача 4: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];

void FillArray(int[] arr)
{
    int lenght = arr.Length;
    for (int i = 0; i < lenght; i++) arr[i] = new Random().Next(0, 2);
}

FillArray(array);

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"{array[i]} ");
}