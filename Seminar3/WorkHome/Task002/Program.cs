//  Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputInt(string msg) 
{
    Console.Write($"{msg}> ");
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;
    int deltaZ = z2 - z1;
    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);    // квадратный корень из суммы квадратов катетов Math - библиотека масс, Sqrt - корень
}

int x1 = InputInt("Введите X координаты А> ");
int y1 = InputInt("Введите Y координаты А> ");
int z1 = InputInt("Введите Z координаты А> ");
System.Console.WriteLine();
int x2 = InputInt("Введите X координаты B> ");
int y2 = InputInt("Введите Y координаты B> ");
int z2 = InputInt("Введите Z координаты B> ");
System.Console.WriteLine($"Расстояние между точками А ({x1}, {y1}, {z1}) и B ({x2}, {y2}, {z2}), равно => {Distance(x1, y1, z1, x2, y2, z2):F2}");