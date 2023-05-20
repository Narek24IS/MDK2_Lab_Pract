/*Вариант №7
2. Определить количество слов в строке исключительно кириллических символов
между словами с максимальной и минимальной длинами. В качестве текста для 
тестового примера (тестовых примеров) взять не менее пяти предложений.
*/

string text = "И поэтому все так произошлоо тогда";

string[] words = text.Split(new char[] { ' ' });

int max = 0, min = words[0].Length;
int minInd = 0, maxInd = 0;

for (int i = 0; i < words.Length; i++)
{
    if (max <= words[i].Length)
    {
        max = words[i].Length;
        maxInd = i;
    }
    if (min >= words[i].Length)
    {
        min = words[i].Length;
        minInd = i;
    }
}
int count = maxInd - minInd - 1;
Console.Write(count);