// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int m = InputInit("Введите 1-ое число => ");
int n = InputInit("Введите 2-ое число=> ");
Console.WriteLine(Akkerman(n, m));

int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Akkerman(n - 1, 1);
    return Akkerman(n - 1, Akkerman (n, m - 1));
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