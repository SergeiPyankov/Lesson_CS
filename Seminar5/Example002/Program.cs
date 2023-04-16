// Задача 2: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void Metod1()
{
    int[] PrintRandomArray(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(-9, 10);
        Console.WriteLine($"Случайно сгенерированный массив из {size} элеменетов => ");
        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");
        return arr;
    }

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


    int[] PrintReverseNumArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++) arr[i] = arr[i] - arr[i] - arr[i];
        Console.WriteLine($"Инверсия массива => ");
        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");
        return arr;
    }

    int size = InputInt("Введите длину массива ");
    int[] array = PrintRandomArray(size);
    System.Console.WriteLine();
    PrintReverseNumArr(array);
}

void Metod2()
{
    int[] PrintRandomArray(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(-9, 10);
        Console.WriteLine($"Случайно сгенерированный массив из {size} элеменетов => ");
        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");
        System.Console.WriteLine();
        Console.WriteLine($"Инверсия массива => ");
        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] - arr[i] - arr[i] + ", ");
        return arr;
    }

    PrintRandomArray(10);
}

Metod2();