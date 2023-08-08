// Задача 39: Напишите программу, которая перевернет одномерный массив
// [1 2 3 4 5] -> [5 4 3 2 1]
// [1 2 3 4 ] -> [ 4 3 2 1]

int[] array = GetArray(10, 0, 10);
PrintArray(array);
System.Console.WriteLine();
// ReversArray1(array);
array = ReversArray2(array);
PrintArray(array);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void ReversArray1(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int tmp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = tmp;
    }

}

int[] ReversArray2(int[] arr)
{
    int[] outArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArray[i] = arr[arr.Length - 1 - i];
    }
    return outArray;
}
