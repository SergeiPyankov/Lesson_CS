Console.WriteLine("Введите первое слагаемое");
string inputValue1 = Console.ReadLine();
int number1 = Convert.ToInt32(inputValue1);
Console.WriteLine("Введите второе слагаемое");
string inputValue2 = Console.ReadLine();
int number2 = Convert.ToInt32(inputValue2);
Console.Write("Сумма двух чисел равна: ");
Console.WriteLine (number1 + number2);

int number3 = new Random().Next(1,10); // (1,2,3....9)
Console.WriteLine(number1);
int number4 = new Random().Next(1,10); // (1,2,3....9)
Console.WriteLine(number2);
int result = number1 + number2;
Console.WriteLine(result);
