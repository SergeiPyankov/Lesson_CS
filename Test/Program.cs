void Increment(int n)
{
    n++;
    Console.WriteLine($"Число в методе Increment: {n}");
}
 
int number = 5;
Console.WriteLine($"Число до метода Increment: {number}");
Increment(number);
Console.WriteLine($"Число после метода Increment: {number}");