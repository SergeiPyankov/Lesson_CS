//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка

int InputInt(string msg)
{
    System.Console.WriteLine($"{msg}> ");
    int value;
    // bool inCorrect = int.TryParse(Console.ReadLine(), out value
    // if (inCorrect)
    if (int.TryParse(Console.ReadLine(), out value)) // упрощенный ввод.    // Конвертирует string в цифровое int, возвращает (out) value
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1); // оператор выхода  из программы  со значением 1
    return 0;   // возвращает значение 0
}

bool ValidateCoords(int x, int y)
{
    if (x == 0 || y == 0)
    {
        System.Console.WriteLine("Вы ввели нолевое значение координат");
        return false;
    }
    return true;
}