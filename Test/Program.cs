int[] arr = new int[5];
RandomArray1(arr, 0, 9);
PrintArray(arr);

void RandomArray1(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"i = {i}");
        array[i] = new Random().Next(min, max + 1);
        Console.WriteLine($"Создал случайное число {array[i]}");
        if (i >= 1)
        {
            Console.WriteLine($"Вошел в цикл if 12");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine($"Вошел в цикл for 15");
                while (array[i] == array[j])
                {
                    Console.WriteLine($"Вошел в цикл while 18");
                    array[i] = new Random().Next(min, max + 1);
                    j = 0;
                    System.Console.WriteLine(array[i]);
                }
                Console.WriteLine($"Я здесь 20");
            }
            Console.WriteLine($"Я здесь 22");
        }
        Console.WriteLine($"Я здесь 24");
    }
}

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) отвечает за длину строк
    {
        System.Console.Write($"{inArray[i]} ");
    }
}