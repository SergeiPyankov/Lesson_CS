//  Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать через функции.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputInit(string msg)
{
    Console.Write(msg);
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

void PrintSqrt(int x, int y)
{
    int count = x;
    for (int i = 1; i < y; i++)
    {
        count = count * x;
        Console.Write($"{count} ");
    }
}

int a = InputInit("Для вычисления квадратa, введите первое число > ");
int b = InputInit("Для вычисления квадратa, введите второе число > ");
PrintSqrt(a, b);