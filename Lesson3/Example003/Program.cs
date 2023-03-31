//Дан текст, в котором необходимо заменить:
//-все пробелы черточками
//-маленькие "к" заменить большими "К"
//-большик "С" заменить маленькими "с"

string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас "
            + "послали вместо нашего милого Винценгероде, вы бы взяли приступом "
            + "согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)   // метод Replace => параметры: строковая переменная "text" => тип данных, указания на символ "char" => заменяемый символ "oldValue" => тип данных, указания на символ "char" => новое значениезаменяемого символа "newValue"
{
    string result = String.Empty;    // создание пустой строки

    int length = text.Length;   // создание числовой переменной "length" => присвоение длины "length" от переменной "text"
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'С', 'с');
System.Console.WriteLine(newText);