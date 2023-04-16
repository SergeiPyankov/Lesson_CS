//  Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).
//  Реализовать через функции. (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)
// 1,2,5,7,19,1,2,8 -> 8

int InputInt(string msg)
{
    Console.Write(msg);
    if (int.TryParse(Console.ReadLine(), out int num))
    {
        return num;
    }
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

int[] RandomArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(min, max + 1);
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("Сгенерированный массив: ");
    for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
    Console.WriteLine();
}


int lengthArray = InputInt("Введите длину массива ");
int minNum = InputInt("Введите минимальное значение для массива ");
int maxNum = InputInt("Введите максимальное значение для массива ");
int[] array = RandomArray(lengthArray, minNum, maxNum);
PrintArray(array);