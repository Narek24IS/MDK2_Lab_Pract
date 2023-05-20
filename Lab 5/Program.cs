/*Вариант №7 (Направления)
Строковому меню предшествует центрированная надпись: «Выберите направление 
движения из списка:». Надпись не участвует в «пролистывании» пунктов меню. В 
качестве пунктов меню предложить: «вверх», «влево», «вниз», «вправо». Реализовать 
маркировку соответствующих пунктов по нажатии на стрелочные клавиши на клавиатуре. 
Выход из меню предусмотреть по нажатии клавиши «Esc». Подтверждение выбранного 
пункта меню реализовать по клавише «Enter».*/

Console.CursorVisible = false;
Console.WriteLine("Нажмите кнопку для выбора:");
Console.BackgroundColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Вниз");
Console.ResetColor();
Console.WriteLine("Вверх");
Console.WriteLine("Влево");
Console.WriteLine("Вправо");
int line = 1;

while (true)
{
    ConsoleKeyInfo ck = Console.ReadKey();
    switch (ck.Key)
    {
        case ConsoleKey.DownArrow:
            line = 1;
            Console.Clear();
            Console.WriteLine("Нажмите кнопку для выбора:");
            Console.BackgroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Вниз");
            Console.ResetColor();
            Console.WriteLine("Вверх");
            Console.WriteLine("Влево");
            Console.WriteLine("Вправо");
            break;
        case ConsoleKey.UpArrow:
            line = 2;
            Console.Clear();
            Console.WriteLine("Нажмите кнопку для выбора:");
            Console.WriteLine("Вниз");
            Console.BackgroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Вверх");
            Console.ResetColor();
            Console.WriteLine("Влево");
            Console.WriteLine("Вправо");
            break;
        case ConsoleKey.LeftArrow:
            line = 3;
            Console.Clear();
            Console.WriteLine("Нажмите кнопку для выбора:");
            Console.WriteLine("Вниз");
            Console.WriteLine("Вверх");
            Console.BackgroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Влево");
            Console.ResetColor();
            Console.WriteLine("Вправо");
            break;
        case ConsoleKey.RightArrow:
            line = 4;
            Console.Clear();
            Console.WriteLine("Нажмите кнопку для выбора:");
            Console.WriteLine("Вниз");
            Console.WriteLine("Вверх");
            Console.WriteLine("Влево");
            Console.BackgroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Вправо");
            Console.ResetColor();
            break;
        case ConsoleKey.Enter:
            Console.Clear();
            switch (line)
            {
                case 1:
                    Console.WriteLine("Вы выбрали пункт \"Вниз\"");
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали пункт \"Вверх\"");
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали пункт \"Влево\"");
                    break;
                case 4:
                    Console.WriteLine("Вы выбрали пункт \"Вправо\"");
                    break;
            }
            break;
        case ConsoleKey.Escape:
            Environment.Exit(0);
            break;
    }
}

