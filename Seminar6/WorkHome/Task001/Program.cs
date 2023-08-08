// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int sizeArr = InputInit("Сколько чисело Вы будете вводить? => ");
int[] userArray = UserNumber(sizeArr);
int x = 0;

for (int i = 0; i < userArray.Length; i++)
{
    if (userArray[i] > 0) x++;
}
System.Console.Write($"Вы ввели {x} чисел больше ноля");


int[] UserNumber(int size)
{
    int[] arr = new int[sizeArr];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1}-ое число => ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int InputInit(string msg)
{
    Console.Write(msg);
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        if (value < 0)
        {
            System.Console.WriteLine("Вы ввели отрицательное значение");
            Environment.Exit(1);
        }
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(2);
    return 0;
}