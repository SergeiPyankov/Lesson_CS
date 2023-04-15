// Задача 2: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int InputInit(string msg)
{
    Console.Write(msg);
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(2);
    return 0;
}

int value = InputInit("Введите число> ");
int i;
System.Console.Write($"Колличество цифр в числе {value}, ");
for (i = 0; value > 0; i++) value = value / 10;
System.Console.WriteLine(i);