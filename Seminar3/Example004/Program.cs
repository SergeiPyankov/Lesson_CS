// Задача 4: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

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

void PrintSqrt(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{i * i}, ");
    }
}

int value = InputInit("Для вычисления квадратов, введите любое число > ");
PrintSqrt(value);
