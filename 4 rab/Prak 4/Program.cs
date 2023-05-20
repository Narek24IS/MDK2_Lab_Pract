/*Вариант №7
Реализовать «выкройку» диагональных элементов одной матрицы и «вклеивание» их поверх 
элементов другой матрицы. «Выкройка» подразумевает обнуление элементов.
*/
int[,] array = { { 0, 1, 2, 3, 4 }, { 0, 1, 2, 3, 4 }, { 0, 1, 2, 3, 4 }, { 0, 1, 2, 3, 4 }, { 0, 1, 2, 3, 4 } };
int[,] array2 = { { 0, 1, 2, 3, 4 }, { 0, 1, 2, 3, 4 }, { 0, 1, 2, 3, 4 }, { 0, 1, 2, 3, 4 }, { 0, 1, 2, 3, 4 } };


Console.WriteLine("Изначальный массив: ");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (i != j) { array[i, j] = 0; }
    }
}

Console.WriteLine("Выкройка диагонали массива: ");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();


for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        array[i, j] += array2[i, j];
    }
}

Console.WriteLine("Массив с вклееной выкройкой: ");

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}