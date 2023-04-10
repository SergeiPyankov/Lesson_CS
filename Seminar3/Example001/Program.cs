// Задача 1: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка

int InputInt(string msg)
{
    System.Console.Write($"{msg}> ");
    //int value; не участвует так как она указана в (9,46)
    // bool inCorrect = int.TryParse(Console.ReadLine(), out value
    // if (inCorrect)
    if (int.TryParse(Console.ReadLine(), out int value)) // упрощенный ввод.    // Конвертирует string в цифровое int, TryParse возвращает или bool или int. Оператором (out value) мы просим вернуть значение в видепеременной value
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1); // оператор выхода из программы со значением 1 (1-  код ошибки). Environment - окружение. Нкжно для понимания, что программа завершилась с ошибкой и прекратиласвое дальнейшее выполнение
    return 0;   // возвращает значение 0 (в данном случае return не нужен так как  до него программане дойдет, используется только для успешной компиляции программы)
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

int GetQuorter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    return 4;
}

int x = InputInt("Введите X> ");
int y = InputInt("Введите Y> ");

if (ValidateCoords(x, y))
{
    Console.WriteLine($"Координаты {x}, {y} находятся в четверти {GetQuorter(x, y)}");
}