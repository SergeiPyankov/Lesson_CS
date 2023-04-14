
// Console.Write("Введите нечетное число> ");
// int.TryParse(Console.ReadLine(), out int value);
// //int value = Convert.Int32(Console.ReadLine());
// int reverse = 0;
// string x;
// for (int i = value; i > 0; i = i / 10) reverse = reverse * 10 + i % 10;
// if (value == reverse)
// {
//     x = "является";
// }
// else  x = "не является";
// Console.WriteLine($"Вы ввели число: {value}, оно {x} палиндромом");

for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.Write($"{i * j} \t");
    }
    Console.WriteLine();
}