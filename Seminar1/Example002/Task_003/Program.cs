// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

System.Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int minusN = -n;
int i = minusN;
while (i <= n)
{
    System.Console.Write(minusN + " ");
    i = i + 1;
    minusN = minusN + 1;
}