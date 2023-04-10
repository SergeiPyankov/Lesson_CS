﻿// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

void Metod1()
{
    int Fibonacci(int n)
    {
        if (n == 1 || n == 2) return 1;
        else return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(Fibonacci(i));
    }
}

void Metod2()
{
    double Fibonacci(int n)
    {
        if (n == 1 || n == 2) return 1;
        else return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    for (int i = 1; i <= 20; i++)
    {
        Console.WriteLine($"f({i}) = {Fibonacci(i)}");
    }
}

//Metod2();

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
