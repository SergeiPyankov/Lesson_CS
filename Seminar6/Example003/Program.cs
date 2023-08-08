// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

void ResArray() // Решение через массив
{
    System.Console.Write("Введите целое число в десятичной системе => ");
    int x = Convert.ToInt32(Console.ReadLine());
    int i = 1;

    for (int j = x; j >= 2; i++)
    {
        j = j / 2;
    }

    int[] bin = new int[i];

    for (int j = i - 1; j >= 0; j--)
    {
        if (x % 2 == 1)
        {
            bin[j] = 1;
        }
        x = x / 2;
    }

    Console.Write($"Введенное число {x} в двоичной системе счисления => ");
    PrintArray(bin);

    void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
    }
}

void ResCycle() // Решение через цикл
{
    System.Console.Write("Введите целое число в десятичной системе => ");
    int x = Convert.ToInt32(Console.ReadLine());
    string i = string.Empty;
    for (; x > 0; x /= 2) i = x % 2 + i;
    System.Console.WriteLine(i);
}

ResCycle();