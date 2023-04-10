// Задача 2: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int InputInt(string msg)    // 
{
    Console.WriteLine($"{msg}> ");
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

bool ValidateQuarter(int qrtr)
{
    if (qrtr < 1)
    {
        Console.WriteLine("Вы ввели число меньше 1");
        return false;
    }
    if (qrtr > 4)
    {
        Console.WriteLine("Вы ввели число больше 4");
        return false;
    }
    return true;
}

// вариант написания с if

void GetCoords1(int qrtr)
{
    if (qrtr == 1)
    {
        Console.WriteLine($"Координаты X > 0 и Y > 0");
    }
    if (qrtr == 2)
    {
        Console.WriteLine($"Координаты X < 0 и Y > 0");
    }
    if (qrtr == 3)
    {
        Console.WriteLine($"Координаты X < 0 и Y < 0");
    }
    if (qrtr == 4)
    {
        Console.WriteLine($"Координаты X > 0 и Y < 0");
    }
}

// вариант написания с switch

(int, int) GetCoords2(int qrtr)  // (int, int) - кортеж (набор возвращаемых переменных)
{
    switch (qrtr)                // альтернатива if. нельзя указывать двойные условия и работает только с простыми значениями
    {
        case 1:                  // если qrtr == 1
            return (1, 1);       // возвращаем значение (1, 1) в кортеж (int, int)
            break;               // не обязателен если есть return
        case 2: return (-1, 1);
        case 3: return (-1, -1);
        default: return (1, -1); // обязательно указывается параметр по умолчанию
    }
}

int quarter = InputInt("Введите номер четверти от 1 до 4"); // создаем переменную quarter. Вызываем функцию InputInt параметром сообщение для пользователя

if (ValidateQuarter(quarter))
{
    (int x, int y) = GetCoords2(quarter);                   // получение пары координат [x, y]
    Console.WriteLine($"Возможные координаты X => {x}, Y => {y}");
    //GetCoords1(quarter);
}