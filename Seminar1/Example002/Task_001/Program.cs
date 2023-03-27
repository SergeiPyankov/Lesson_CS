// Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

Console.Write("Введите первое число "); 
string inputValue1 = Console.ReadLine();
int value1 = Convert.ToInt32(inputValue1);

Console.Write("Введите второе число "); 
string inputValue2 = Console.ReadLine();
int value2 = Convert.ToInt32(inputValue2);

if(value2 == value1 * value1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}