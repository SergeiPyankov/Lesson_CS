// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int number = InputInit("Введите максимальное значение => ");
int count = 0;
// NaturalNumber(number, count);
System.Console.WriteLine(PrintNumber(number));

void NaturalNumber(int number, int i) // рекурсия через переменную
{
    if (i <= number)
    {
        System.Console.Write(i + " ");
        NaturalNumber(number, i += 1);
    }
}

string PrintNumber(int number) // рекурсия через строку
{
    if (number == 1) return "1";
    return $"{PrintNumber(number - 1)} {number}";
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