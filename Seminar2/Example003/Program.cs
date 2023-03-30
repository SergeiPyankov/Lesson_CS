// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int Prompt1(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

bool Prompt2(int a, int b)
{
    if (a % b == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int num1 = Prompt1("Введите 1-е число");
int num2 = Prompt1("Введите 2-е число");

if (Prompt2(num1, num2))
{
    System.Console.WriteLine(num2 + " кратно " + num1);
}
else
{
    int num3 = num1 % num2;
    System.Console.WriteLine($"{num2} не кратно {num1} , остаток {num3}");
}
