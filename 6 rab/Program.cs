StreamReader file = new StreamReader("check.txt");
double totalCost = 0;

while (!file.EndOfStream)
{
    string line = file.ReadLine();
    string[] elements = line.Split(' ');

    int quantity = Convert.ToInt32(elements[2]);
    double price = Convert.ToDouble(elements[3]);

    totalCost += quantity * price;
}

file.Close();
Console.WriteLine("Общая стоимость покупки: " + totalCost);
Console.ReadLine();
