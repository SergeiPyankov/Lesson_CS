// Примеры методов
// 1. ничего не принимают, ничего не возвращают - void метод
// 2. что-то принимают, ничего не возвращают    - void метод
// 3. ничего не принимают, что-то возвращают
// 4. что-то принимают, что-то возвращают

// Тип 1

void Metod1() 
{
    System.Console.WriteLine("Автор: Иван Пупкин"); // тело метода
}

Metod1(); // вызов метода

// Тип 2

void Metod2(string msg)
{
    System.Console.WriteLine($"Привет, {msg}");
}

Metod2("Иван Пупкин");

// 2.1

void Metod21(string msg1, string msg2)
{
    System.Console.WriteLine($"Привет, {msg1}, {msg2}");
}

Metod21(msg1: "Иван", msg2: "Пупкин");

// 2.2

void Metod22(string msg, int count) // метод с двумя параметрами
{
    if (i < count)
    {
    System.Console.WriteLine($"Привет, {msg}");
    i++;    // инкремент
    }
}

Metod22(msg1: "Иван", 4);   // Вызовет метод с текстом: Иван 4 раза
Metod22(msg1: "Иван", count: 4); // Альтернативный способ вызова (порядок аргументов не имеет значения)

// Тип 3

int Metod3() // нет аргумента
{
    return DateTime.Now/Year; // в качестве аргумента возвращает текущий год
}

int year = Metod3(); // создается новая переменная "year", метод присваивает переменной текущий год
System.Console.WriteLine($"Текущий год {year}");


// Тип 4

string Metod4(int count, string text)
{
    int i = 0;
    string resalt = String.Empty;   // строковая переменная "resalt" с пустой строкой "String.Empty". Аналогичный ввод: string resalt = "";

    while (i < count)
    {
        resalt = resalt + text;
        i++;
    }
    return resalt;
}

string res = Metod4(4, "Текст + ");    // Текст + Текст + Текст + Текст + 
System.Console.WriteLine(res);

// Описание метода с использованием "for"

string Metod41(int count, string text)
{
    //int i = 0; - перенесено в "for"
    string resalt = String.Empty;
    for (int i = 0; i < count; i++)
    //wile (i < count) - перенесено в "for"
    {
        resalt = resalt + text;
        //i++; - перенесено в "for"
    }
    return resalt;
}

string res = Metod1(4, "Текст + ");    // Текст + Текст + Текст + Текст + 
System.Console.WriteLine(res);