System.Console.Write("Введите целое число в десятичной системе => ");
int x = Convert.ToInt32(Console.ReadLine());
string i = string.Empty;
for (; x > 0; x /= 2) i = x % 2 + i;
System.Console.WriteLine(i);