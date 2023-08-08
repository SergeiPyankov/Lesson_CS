//  Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3, 7.4, 22.3, 2, 78] -> 76

double[] PrintRandomArray(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++) 
    {
        arr[i] = new Random().Next(1,10) * new Random().NextDouble();
    }
    Console.Write($"Случайно сгенерированный массив из {size} элеменетов => ");
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + ", ");
    return arr;
}

double SumNumber(double[] arr)
{
    double min = 0;
    double max = 0;
    if 
    return summa;
}

double[] array = PrintRandomArray(10);
System.Console.WriteLine($"Разницу между максимальным и минимальным элементом массива равна => {SumNumber(array)}");
