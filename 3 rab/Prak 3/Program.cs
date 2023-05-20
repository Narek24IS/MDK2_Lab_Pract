/*7 вариант
 Напечатать таблицу значений функции  sin и cos  на интервале 10-90 градусов с шагом 10.*/
double convGrad(double x)
{
    return (x * Math.PI) / 180;
}

Console.Write("Sin: ");
for (int i = 10; i <= 90; i += 10)
{
    Console.Write(i + " = ");
    Console.Write(Math.Round(Math.Sin(convGrad(i)), 2) + ", ");
}

Console.WriteLine();
Console.Write("Cos: ");
for (int i = 10; i <= 90; i += 10)
{
    Console.Write(i + " = ");
    Console.Write(Math.Round(Math.Cos(convGrad(i)), 2) + ", ");
}