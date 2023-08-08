// Задача 3: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int InputInt(string msg)
{
    Console.Write(msg);
    if (int.TryParse(Console.ReadLine(), out int num))
    {
        return num;
    }
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

int[] PrintRandomArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(1, 10);
    Console.Write($"Случайно сгенерированный массив из {size} элементов от 1 до 9: ");
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");
    return arr;
} 

string SearchUserNum(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        return "Yes";
    }
    return "No";
}

int sizeArray = InputInt("Введите длину массива => ");
int userNumber = InputInt("Введите искомое число => ");
int[] array = PrintRandomArray(sizeArray);
Console.WriteLine("=> " + SearchUserNum(array, userNumber));
