// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

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

int Summa(int num)
{
    int j = 0;
    for (int i = 1; i <= num; i++) j += i;
    return j;
}
int value = InputInit("Введите число> ");
System.Console.WriteLine(Summa(value));