// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число "); 
string inputValue1 = Console.ReadLine();
int number1 = Convert.ToInt32(inputValue1);

Console.Write("Введите второе число "); 
string inputValue2 = Console.ReadLine();
int number2 = Convert.ToInt32(inputValue2);

Console.Write("Введите третье число "); 
string inputValue3 = Console.ReadLine();
int number3 = Convert.ToInt32(inputValue3);

int max = number1;

if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}
System.Console.WriteLine($"Наибольшее число {max}");