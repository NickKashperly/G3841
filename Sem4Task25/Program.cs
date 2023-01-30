//Задача 25: 
//Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1)
{
    Console.WriteLine(msg1);

}

//Метод подсчета количество цифр
string Pow(int x, int y)
{
    string res = string.Empty;
    res = Math.Pow(x, y).ToString();
    return res;
}
int numA = ReadData("Введите число: A ");
int numB = ReadData("Введите число: B ");
string num = Pow(numA, numB);
PrintData(num);
