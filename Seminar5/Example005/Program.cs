// Задача 5: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] PrintRandomArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(minValue, maxValue);
    Console.Write($"Случайно сгенерированный массив из 10 элементов от 1 до 9 => ");
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");
    System.Console.WriteLine();
    return arr;
}

int[] CompositionNumArray(int[] arr)    // метод перемножения первых и последних элементов массива
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

int[] PairsArray(int[] arr) // альтернативный метод перемножения
{
    int[] result = new int[arr.Length / 2 + arr.Length % 2];
    result[^1] = arr[result.Length - 1];   // если массив не четный, то на последнее место ставится значение среднего элемента основного массива, если массив четный, то при проходе for (36) последний элемент сотрется и заменится (39)
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int lastIndex = arr.Length - 1 - i;
        result[i] = arr[i] * arr[lastIndex];
    }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");
}

int size = 5;
int minValue = 1;
int maxValue = 6;
int[] array = PrintRandomArray(size, minValue, maxValue);
int[] compositionArray = CompositionNumArray(array);
//PrintArray(compositionArray);
PrintArray(PairsArray(array));