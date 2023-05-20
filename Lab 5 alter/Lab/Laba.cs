/*Альтернативное меню*/

Console.CursorVisible = false;
Console.WriteLine("Нажмите кнопку для выбора:");
Console.BackgroundColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("1 пункт");
Console.ResetColor();
Console.WriteLine("2 пункт");
Console.WriteLine("3 пункт");
Console.WriteLine("4  пункт");
int line = 1;

while (true)
{
    ConsoleKeyInfo ck = Console.ReadKey();
    switch (ck.Key)
    {
        case ConsoleKey.DownArrow:
            line++;
            if (line > 4)
                line = 1;
            break;
        case ConsoleKey.UpArrow:
            line--;
            if (line < 1)
                line = 4;
            break;
    }
    switch (line)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Нажмите кнопку для выбора:");
            Console.BackgroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("1 пункт");
            Console.ResetColor();
            Console.WriteLine("2 пункт");
            Console.WriteLine("3 пункт");
            Console.WriteLine("4 пункт");
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Нажмите кнопку для выбора:");
            Console.WriteLine("1 пункт");
            Console.BackgroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("2 пункт");
            Console.ResetColor();
            Console.WriteLine("3 пункт");
            Console.WriteLine("4 пункт");
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Нажмите кнопку для выбора:");
            Console.WriteLine("1 пункт");
            Console.WriteLine("2 пункт");
            Console.BackgroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("3 пункт");
            Console.ResetColor();
            Console.WriteLine("4 пункт");
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Нажмите кнопку для выбора:");
            Console.WriteLine("1 пункт");
            Console.WriteLine("2 пункт");
            Console.WriteLine("3 пункт");
            Console.BackgroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("4 пункт");
            Console.ResetColor();
            break;
    }
}


