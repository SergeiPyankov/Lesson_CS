// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число ");
string inputValue1 = Console.ReadLine();
int value1 = Convert.ToInt32(inputValue1);

Console.Write("Введите второе число ");
string inputValue2 = Console.ReadLine();
int value2 = Convert.ToInt32(inputValue2);

if (value1 > value2)
{
    int min = value2;
    int max = value1;
    System.Console.WriteLine($"Наименьшее число {min}, наибольшее число {max}");
}
else
{
    int min = value1;
    int max = value2;
    System.Console.WriteLine($"Наименьшее число {min}, наибольшее число {max}");
}