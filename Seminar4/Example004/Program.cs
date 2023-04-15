// Задача 4: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void Metod1()
{
    int[] FillArray(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0, 2);
        return arr;
    }

    int[] array = FillArray(8);

    for (int i = 0; i < array.Length; i++)
    {
        System.Threading.Thread.Sleep(100); // таймаут выполнения
        System.Console.Write($"{array[i]} ");
    }
}

void Metod2()
{
    void FillArray(int[] arr)
    {
        Random rnd = new Random();
        //int index = rnd.Next(0, arr.Length + 1) альт ввод
        for (int i = 0; i < arr.Length / 2; i++)
        {
            arr[rnd.Next(0, arr.Length)] = 1;
            //arr[index] = 1 альт ввод
        }
    }

    void PrintArray(int[] arr)
    {
        System.Console.Write($"{arr[0]} ");
        for (int i = 1; i < arr.Length; i++) System.Console.Write($"{arr[i]} ");
    }

    int[] array = new int[8];
    FillArray(array);
    PrintArray(array);
}


Metod2();