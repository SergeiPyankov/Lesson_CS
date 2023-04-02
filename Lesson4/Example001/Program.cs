void Metod1()   // Двумерный массив из строк
{
    string[,] table = new string[2, 5]; // строковый (string) двумерный массив [,] table = генерация нового строкового массива с 2 строками и 5 столбцами
    // table[0,0]   table[0,1]  table[0,2]  table[0,3]  table[0,4]
    // table[1,0]   table[1,1]  table[1,2]  table[1,3]  table[1,4]
    table[1, 2] = "слово";
    // table[0, 0] = "1";
    // table[0, 1] = "2";
    // table[0, 2] = "3";
    // table[0, 3] = "4";
    // table[0, 4] = "5";
    // table[1, 0] = "6";
    // table[1, 1] = "7";
    // table[1, 2] = "8";
    // table[1, 3] = "9";
    // table[1, 4] = "10";

    for (int rows = 0; rows < 2; rows++)
    {
        for (int columns = 0; columns < 5; columns++)
        {
            Console.WriteLine($"{table[rows, columns]}");
        }
    }
}

void Metod2()   // Двумерный массив из чисел
{
    void PrintArray(int[,] mtrx)
    {
        for (int rows = 0; rows < mtrx.GetLength(0); rows++)  // matrix.GetLength(0) - длина двумерного массива с указанием на строку 0
        {
            for (int columns = 0; columns < mtrx.GetLength(1); columns++)  // matrix.GetLength(1) - длина двумерного массива с указанием на столбец 1
            {
                Console.Write($"{mtrx[rows, columns]} ");
            }
            System.Console.WriteLine();
        }
    }

    void FillArray(int[,] mtrx)
    {
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            for (int j = 0; j < mtrx.GetLength(1); j++)
            {
                mtrx[i, j] = new Random().Next(1, 10);
                Console.Write($"{mtrx[i, j]} ");
            }
            System.Console.WriteLine();
        }

    }

    int[,] matrix = new int[3, 4];
    PrintArray(matrix);
    System.Console.WriteLine();
    FillArray(matrix);
}

Metod2();