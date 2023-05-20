/*7 вариант
Вводится символ арифметического оператора. Ответить его названием.*/
char op = '\0';

while (op != 'q')
{
    Console.Write("Введите знак оператора:");
    op = Console.ReadKey().KeyChar;
    Console.WriteLine();
    switch (op)
    {
        case '=':
            Console.WriteLine("Равно");
            break;
        case '+':
            Console.WriteLine("Плюс");
            break;
        case '-':
            Console.WriteLine("Минус");
            break;
        case '*':
            Console.WriteLine("Умножение");
            break;
        case '/':
            Console.WriteLine("Деление");
            break;
        default:
            Console.WriteLine("Не арифметическая операция!");
            break;
    }
}
