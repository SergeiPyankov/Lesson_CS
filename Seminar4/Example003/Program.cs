// Задача 3: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int InputInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int CountNumber(int val)
{
    int count;
    for (int i = 1; i > num; i++) count = i * i++;
    return count;
}

int value = InputInt("Введите число> ");
System.Console.WriteLine($"Произведение чисел от 1 до {value} = {CountNumber(value)}");