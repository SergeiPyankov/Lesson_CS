// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// Console.Clear();
int m = InputInit("Введите  значение M => ");
int n = InputInit("Введите значение N => ");
if (m < n) NaturalNumber(m, n);
if (m > n) NaturalNumber(n, m);


void NaturalNumber(int i, int j)
{
    if ( i <= j)
    {
        System.Console.Write(i + " ");
        NaturalNumber(i += 1, j);
    }
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
        if (value > 101)
        {
            System.Console.WriteLine("Введите число до 10");
            Environment.Exit(2);
        }
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(3);
    return 0;
}