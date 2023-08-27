// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = InputInit("Введите 1-ое число => ");
int n = InputInit("Введите 2-ое число=> ");
Console.WriteLine(SumNumber(m, n));

int SumNumber(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return m += SumNumber(m + 1, n);
}

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
        if (value > 1000)
        {
            System.Console.WriteLine("Введите число до 1000");
            Environment.Exit(2);
        }
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(3);
    return 0;
}