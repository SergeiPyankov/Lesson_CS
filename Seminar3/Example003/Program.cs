// Задача 3: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

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

double Distance(int x1, int y1, int x2, int y2)
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;
    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);    // квадратный корень из суммы квадратов катетов Math - библиотека масс, Sqrt - корень
}

int x1 = InputInt("Введите X координаты А> ");
int y1 = InputInt("Введите Y координаты А> ");
System.Console.WriteLine();
int x2 = InputInt("Введите X координаты B> ");
int y2 = InputInt("Введите Y координаты B> ");
System.Console.WriteLine($"Расстояние между точками А ({x1}, {y1}) и B ({x2}, {y2}), равно => {Distance(x1, y1, x2, y2):F3}");  // F3 - сокращает кол-во выводимых знаков до 3-х после запятой