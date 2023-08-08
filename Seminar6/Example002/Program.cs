// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. 
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

// int[] side = new int[3];
// side[0] = InputUser("Введите длину стороны А> ");
// side[1] = InputUser("Введите длину стороны B> ");
// side[2] = InputUser("Введите длину стороны C> ");
// Console.Write($"Стороны треугольника: ");
// PrintArray(side);
// int x = side[0] + side[1] + side[2] / 3;
// for (int i = 0; i < side.Length; i++)
// {
//     if (side[i] < x);
//     else System.Console.WriteLine("Треугольник существовать не может");
// }

// int InputUser(string msg)
// {
//     Console.Write(msg);
//     int x = Convert.ToInt32(Console.ReadLine());
//     return x;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }

System.Console.WriteLine("Введите три числа => ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a + b > c && b + c > a && c + a > b)
{
    System.Console.WriteLine("Треугольник существовать может");
}
else System.Console.WriteLine("Треугольник существовать не может");