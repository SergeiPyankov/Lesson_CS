// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

// Console.Write("Введите число дня недели от 1 до 7: ");
// string inputDate = Console.ReadLine();

// if (inputDate == "1")
// {
//     Console.WriteLine("Понедельник");
// }
// if (inputDate == "2")
// {
//     Console.WriteLine("Вторник");
// }
// if (inputDate == "3")
// {
//     Console.WriteLine("Среда");
// }
// if (inputDate == "4")
// {
//     Console.WriteLine("Четверг");
// }
// if (inputDate == "5")
// {
//     Console.WriteLine("Пятница");
// }
// if (inputDate == "6")
// {
//     Console.WriteLine("Суббота");
// }
// if (inputDate == "7")
// {
//     Console.WriteLine("Воскресенье");
// }
// if (inputDate < 1 || inputDate > 7)
// {
//     Console.WriteLine("Ошибка");
// }

// Альтернативный пример решения с применением массива

string[] week = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };  // Создание массива из 7 переменных
while (true)                                                                                                          // Цикл: пока правда (true), цикл повторяется 
{
    Console.WriteLine("Введите число от 1 до 7");                                                                     // запрос на ввод данных пользователя
    int userNumber = Convert.ToInt32(Console.ReadLine());                                                             // конвертация строкив целое число
    if (userNumber < 1 || userNumber > 7)                                                                             // если число пользователя меньше 1 и ("||") больше 7
    {
        Console.WriteLine("Вы ввели некорректное число");                                                             // если да то вывести предупреждение об ошибке
    }
    else                                                                                                              // если нет то:
    {
        int weekIndex = userNumber - 1;                                                                               // присваивание индекса в двоичной системе (0,1,2,3,4,5,6)
        Console.WriteLine($"Вы ввели число {userNumber} это день недели: {week[weekIndex]}");                         // вывод итогового значения
        break;
    }
}