//  Напишитепрограмму,которая выводит случайное число из отрезка (10, 9999) и показывает наибольшую цифру числа

int count = new Random().Next(10, 10000);
System.Console.WriteLine($" случайное число > {count}");

int max = 0;
int number = count;

while (count > 0)
{
    if (max < count % 10)
    {
        max = count % 10;
    }
    count /= 10;
}
System.Console.WriteLine($" Максимальная цифра из числа {number}> {max}");