int Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
//Console.WriteLine(Factorial(5)); // 1 * 2 * 3 = 6

// Factorial(int 5)
// не равно 1
// n * Factorial (5 - 1) запуск функции с 4
// не равно 1?
// n * Factorial (4 - 1) запуск функции с 3
// не равно 1?
// n * Factorial (3 - 1) запуск функции с 2
// не равно 1?
// n * Factorial (2 - 1) запуск функции с 1
// равно 1?
// возвращает 1 

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
// с большими числами тип данных int будет вызывать переполнение, что выдаст отрицательные значения. Один из способов решения - заменить типданных на double