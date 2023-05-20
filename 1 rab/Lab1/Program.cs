/*7 вариант
 Вычислить гиперболический косинус двумя способами*/

Console.Write("1.Использование встроенной функции Math.Cosh(): ");


double x = 3.56; // аргумент гиперболического косинуса
double result = Math.Cosh(x);

Console.WriteLine(result);


Console.Write("2.Использование формулы cosh(x) = (e ^ x + e ^ (-x)) / 2: ");


x = 3.56; // аргумент гиперболического косинуса
result = (Math.Exp(x) + Math.Exp(-x)) / 2;

Console.WriteLine(result);