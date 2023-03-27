// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Запрос данных и их конвертация

// Пример преподавателя

Console.Write("Введите число ");            // Вывод в консоль приглашения для ввода
string inputValue;                          // Объявлениен переменной
inputValue = Console.ReadLine();            // Присвоение переменной из консоли
int value = Convert.ToInt32(inputValue);    // Конвертация строки в целое число

int square = value * value;                 // Вычисление квадрата

                                            // Вывод на экран
Console.WriteLine("Квадрат числа " + value + " равен " + square);
Console.WriteLine($"Квадрат числа {value} равен {square}");

// Мой пример

// Console.Write("Введите число "); 
// string inputValue = Console.ReadLine(); // запрос на ввод строки
// int value = Convert.ToInt32(inputValue); // Конвертация строки в целое натуральное число
// Console.Write("Квадрат числа равен: ");
// Console.WriteLine(value * value);




