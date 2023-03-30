// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

string[] week = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

while (true)
{
    Console.WriteLine("Введите число от 1 до 7");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    if (userNumber > 0 && userNumber < 8)
    {
        if (userNumber == 6 || userNumber == 7)
        {
            Console.WriteLine($"{week[userNumber - 1]} - является выходным");
            break;
        }
        else
        {
            Console.WriteLine($"{week[userNumber - 1]} - является рабочим");
            break;
        }
    }
    else
    {
        System.Console.WriteLine("Вы ввели некоретную дату");
    }
}
    