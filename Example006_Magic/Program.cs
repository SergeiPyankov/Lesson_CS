Console.Clear();

int xa = 60, ya = 1, 
    xb = 1, yb = 40,
    xc = 120, yc = 40;

//Console.SetCursorPosition(xa, ya);
//Console.Write("+");

//Console.SetCursorPosition(xb, yb);
//Console.Write("+");

//Console.SetCursorPosition(xc, yc);
//Console.Write("+");

int x = 30, y = 20;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0,3); // 0,1,2
    if(what == 0)
    {
        x = (x+xa) / 2;
        y = (y+ya) / 2;
    }

    if(what == 1)
    {
        x = (x+xb) / 2;
        y = (y+yb) / 2;
    }

    if(what == 2)
    {
        x = (x+xc) / 2;
        y = (y+yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.Write("+");
    count = count + 1; // count +=1; или count++;
}
Console.SetCursorPosition(1, 41);