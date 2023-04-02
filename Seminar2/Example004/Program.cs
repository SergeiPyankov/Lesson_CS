// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
// 46 -> нет 
// 161 -> да

int Prompt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int num = Prompt("Введите число > ");
int divider1 = Prompt("Введите делитель 1 > ");
int divider2 = Prompt("Введите делитель 2 > ");

if (num % divider1 == 0 && num % divider2 == 0)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}