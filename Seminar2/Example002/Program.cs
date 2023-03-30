// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int randomDigit = new Random() .Next(10, 100);
System.Console.WriteLine($"Случайно сгенерирорванное число > {randomDigit}");

int digit1 = randomDigit / 10;
int digit2 = randomDigit % 10;
int max = digit1;

if (max > digit2)
{
    System.Console.WriteLine($"Максимальная цифра числа равна > {digit1}");
}
else
{
    System.Console.WriteLine($"Максимальная цифра числа равна > {digit2}");
}