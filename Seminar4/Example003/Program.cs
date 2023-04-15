// Задача 3: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int InputInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

double Factorial(int val)
{
    double count = 1;
    for (int i = 1; i <= val; i++)
    {
        count *= i;
        System.Console.WriteLine(count);
    }
        return count;
}

int value = InputInt("Введите число> ");
System.Console.WriteLine($"Произведение чисел от 1 до {value} = {Factorial(value)}");