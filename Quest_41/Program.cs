// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

// Методы

// Метод считывания массива с клавиатуры ввода

string[] ReadingText ()
{
Console.Write("Введите числа через запятую и пробел: ");
string[] array = Console.ReadLine()!.Split(", ", StringSplitOptions.RemoveEmptyEntries);
return array;
}

// Метод определения количества положительных чисел

int quantity (string[] array)
{int count = 0;
for (int i = 0; i < array.Length; i++)
{
  if (int.Parse(array[i]) > 0) count++;
}
return count;
}

// Основные действия

string[] number = ReadingText();

int quant = quantity(number);

Console.Write($"Количество положительных чисел равно {quant}");
