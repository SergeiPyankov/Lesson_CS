//  Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int InputInt(string msg)
{
    Console.Write(msg);
    bool check = int.TryParse(Console.ReadLine(), out int value);
    if (check)
    {
        if (value % 2 != 0)
        {
            return value;
        }
        Console.WriteLine("Вы ввели четное число");
        Environment.Exit(1);
        return 0;
    }
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(2);
    return 0;
}

int ReverseNumber(int num)
{
    int reverse;
    for (reverse = 0; num > 0; num = num / 10) reverse = reverse * 10 + num % 10;
    return reverse;
}

string CheckPlrm(int val, int rev)
{
    if (val == rev)
    {
        return "является";
    }
    return "не является";
}

int value = InputInt("Введите нечетное число> ");
int reverse =  ReverseNumber(value);
Console.WriteLine($"Вы ввели число: {value}, оно {CheckPlrm(value, reverse)} палиндромом");