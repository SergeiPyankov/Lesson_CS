int[,] arr = new int[,] { { 1, 1, 1 }, { 2, 2, 2}, { 3, 3, 3}, { 4, 4, 4} };
System.Console.WriteLine(arr.GetLength(0));


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++) 
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            System.Console.Write($"{inArray[i, j]} ");
        }
        System.Console.WriteLine();
    }
}