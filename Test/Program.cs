int number = InputInit("Введите число => ");
Console.WriteLine(SumNumber(number));

int SumNumber(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return number % 10 + SumNumber(number / 10);
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