// Задача №0
// Программа возводит в квадрат
string? inputNum = Console.ReadLine();
// Считываем данные с консоли
if (inputNum!=null)
{
//Парсим введенное число
int number = int.Parse(inputNum);
// Находим квадрат числа
//int result = number*number;

int result = (int)Math.Pow(number, 2);

// Выводим данные на консоль
Console.WriteLine(result);

//// Console.WriteLine(Math.Pow(int.Parse(inputNum),2));



}