//  Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

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

void SumNumber(int x)
{
    Console.Write($"Сумма чисел в числе {x} равна ");
    int count = 0;
    while (x > 0)
    {
        count = count + x % 10;
        x /= 10;
    }
    Console.Write(count);
}

int userNumber = InputInit("Введите любое число ");
SumNumber(userNumber);