// Шаблоны методов

// Ввод значений

Console.Write("Введите первое число ");
string inputValue1 = Console.ReadLine();
int value1 = Convert.ToInt32(inputValue1);

// Ввод пользовательских значений

int InputInt(string msg)
{
    System.Console.Write($"{msg}> ");
    if (int.TryParse(Console.ReadLine(), out int value)) return value;
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1); 
    return 0;
}

// Ввод пользовательских значений с допоплнительным условием

int InputInit(string msg)
{
    Console.Write(msg);
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        if (value < 0)
        {
            System.Console.WriteLine("Вы ввели отрицательное значение");
            Environment.Exit(1);
        }
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(2);
    return 0;
}

// Создание и вывод массива из случайных чисел

int[] PrintRandomArray(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0, 10);
        Console.WriteLine($"Случайно сгенерированный массив из {size} элеменетов => ");
        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");
        return arr;
    }

// Вывод массива на экран

void PrintArray(int[] arr)
    {
        System.Console.Write($"{arr[0]} ");
        for (int i = 1; i < arr.Length; i++) System.Console.Write($"{arr[i]} ");
    }

// Создание и заполниение массива случайными числами

int[] FillArray(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0, 10);
        return arr;
    }

// Поиск второго максимального

int SecondMax(int[] arr)
{
    int smax = 0, max = arr[0];

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

// поиск конкретного значения в массиве

string SearchUserNum(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        return "Yes";
    }
    return "No";
}

// смена положительных иотрицательных значений массива (с + на - ; с - на +)

int[] PrintReverseNumArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++) arr[i] *= -1;
        Console.WriteLine($"Инверсия массива => ");
        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");
        return arr;
    }

// Перемножение  первых и последних чисел массива

int[] CompositionNumArray(int[] arr)
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

// Поиск двузначных чисел

int SearchTwoDigits(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++) if (arr[i] > 9 && arr[i] < 100) count++;
    return count;
}

// Факториал

double Factorial(int val)
{
    double count = 1;
    for (int i = 1; i <= val; i++)
    {
        count *= i;
        System.Console.WriteLine(count);
    }
        return count;
}
