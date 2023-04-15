// Задача 5: Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Постарайтесь сделать одним циклом 
// [1, 3, 5, 6, 6, 4] -> 5

int InputInt(string msg)
{
    Console.WriteLine(msg);
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

int[] RandomArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0, 100);
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("Случайно сгенерированный массив: ");
    for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int SecondMax(int[] arr)
{
    int smax = 0;
    int max = arr[0];

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

int sizeArray = InputInt($"Введите длину массива> ");
int[] array = RandomArray(sizeArray);
PrintArray(array);
int secMax = SecondMax(array);
Console.Write($"Второе максимальное число в массиве: {secMax}");
