// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 

int a = InputInit("Введите число => ");
int b = InputInit("Введите степень => ");
Console.WriteLine(SumNumber(a, b));

int SumNumber(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    return a *= SumNumber(a, b - 1);
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