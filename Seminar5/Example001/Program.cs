// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

void MyMetod()
{
    int[] PrintRandomArray()
    {
        int[] arr = new int[12];
        // Random rnd = new Random();   // Создание генератора случайных чисел
        for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(-9, 10);    // arr[i] = rnd.Next(-9, 10); присваиваем случайное число элементу массива
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
            if (arr[i] > 0) pos += arr[i];
            else neg += arr[i];
        }
    }

    int[] array = PrintRandomArray();
    SumPositiveNegative(array, out int positive, out int negative);
    System.Console.Write($"Сумма положительных значений массива равна {positive}, Сумма отрицательных значений массива равна {negative}");
}

void GBMetod()
{
    int[] PrintRandomArray()
    {
        int[] arr = new int[12];
        Random rnd = new Random();   // Создание генератора случайных чисел
        for (int i = 0; i < arr.Length; i++) arr[i] = rnd.Next(-9, 10);    // arr[i] = rnd.Next(-9, 10); присваиваем случайное число элементу массива
        Console.Write($"Случайно сгенерированный массив от -9 до 9 => ");
        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");
        return arr;
    }

    int SumPositiveNegative(int[] arr, bool isPositive = true)  // принимает на вход массив и переменную bool которой изначально присваивается значение true, но (56:103) присваивает ей false
    {
        int sign = 1;
        if (!isPositive) sign = -1;   // не равно isPositive (false)
        int sum = 0;
        for (int i = 0; i < arr.Length; i++) if (arr[i] * sign > 0) sum += arr[i];  // * sign - в зависимости от true/false (44.45) считает положительные или отрицательные числа
        return sum;
    }

    int[] array = PrintRandomArray();
    SumPositiveNegative(array);
    System.Console.WriteLine($"Сумма положительных значений массива равна {SumPositiveNegative(array)}");
    System.Console.WriteLine($"Сумма отрицательных значений массива равна {SumPositiveNegative(array, false)}");
}

GBMetod();