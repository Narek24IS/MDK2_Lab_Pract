﻿/*Вариант №7
1. Из текста удалить каждое второе слово. Условие: известно, что слова
разделены пробелом и только одним. В качестве текста для тестового примера 
(тестовых примеров) взять не менее пяти предложений.
*/

string text = "И поэтому все так произошло";

string[] words = text.Split(new char[] { ' ' });

for (int i = 0; i < words.Length; i++)
{
    if (i % 2 == 1)
    {
        words[i] = "";
    }
}

foreach (string s in words)
{
    Console.Write(s + ' ');
}
