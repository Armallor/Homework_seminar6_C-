// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

// Метод ввода значений

double vvod (string text)
{
  Console.Write(text);
  return Convert.ToDouble(Console.ReadLine()!);
}

// Метод определения координат точек пересечения

string rezult (double x1, double y1, double x2, double y2, string text)
{
  string text1 = new string("Одна или обе функции являются точками, а не прямыми");
  string text2 = new string("Прямые совпадают");
  string text3 = new string("Прямые параллельны");
  string text4 = new string($"Прямые пересекаются в точке с координатами X = {(y2-y1) / (x1-x2)} и Y = {(x2 * y1 - x1 * y2) / (x2 - x1)}");
  if (x1 == 0 || x2 == 0) text = text1;
  else if ((x1 == x2) & (y1 == y2)) text = text2;
  else if (x1 == x2) text = text3;
  else text = text4;
return text;
}

// Основные действия

double k1 = vvod("Введите значение коэффициента k1 ");
double b1 = vvod("Введите значение коэффициента b1 ");
double k2 = vvod("Введите значение коэффициента k2 ");
double b2 = vvod("Введите значение коэффициента b2 ");

string notext = new string("");

string result = rezult(k1, b1, k2, b2, notext);
Console.Write($"{result}");