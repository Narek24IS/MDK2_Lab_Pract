/*Вариант №7
В заданном одномерном массиве чисел определить позиции максимального и минимального
значений. Счёт позиций начинается с единицы при индексации массива с нуля.
*/

int[] array = { 6, 3, 1, 2, 4, 5, 7, 9, 8, 0 };
int min = array[0];
for (int i = 0; i < 10; i++)
{
    if (array[i] < min)
    {
        min = i + 1;
    }
}
int max = array[0];
for (int i = 0; i < 10; i++)
{
    if (array[i] > max)
    {
        max = i + 1;
    }
}

Console.WriteLine("MaxPos = " + max + "\nMinPos = " + min);