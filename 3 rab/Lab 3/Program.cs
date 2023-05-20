double G = 0, x = 5, z = 5;
Console.Write("Введите количество элементов ряда: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
        G += (0.8 * Math.Pow(z, 1 - i) * i + Math.Cos(Math.Pow(z, i))) / (Math.Sqrt(Math.Pow(x, 2 * i) + 5 * i + (20 + 5 * i)));
    else
        G += (0.8 * Math.Pow(z, 1 - i) * i - Math.Sin(Math.Pow(z, i))) / (Math.Sqrt(Math.Pow(x, 2 * i) + 5 * i + (20 + 5 * i)));
}
Console.Write("Сумма элементов ряда: ");
Console.WriteLine(G.ToString());