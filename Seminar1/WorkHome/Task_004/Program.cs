// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число ");
string inputValue = Console.ReadLine();
int number = Convert.ToInt32(inputValue);
int i = 2;

if (number % 2 != 0)
{
    number--;
}
while (i <= number)
{
    System.Console.WriteLine($"{i} ");
    i += 2;
}