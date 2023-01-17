// int num1 = int.Parse(Console.ReadLine()??"0");

// int num2 = int.Parse(Console.ReadLine()??"0");

// if(num1*num1 == num2)
// {
//     Console.WriteLine("Второе число квадрат первого");

// }
// ifelse(num2*num2 == num1)
// {
//     Console.WriteLine("Первое число квадрат второго");
// }
// else
// {
//     Console.WriteLine("не квадраты чисел");
// }
Console.WriteLine("input yor nums: ");
// Вводим данные с консоли
int num1 = int.Parse(Console.ReadLine() ?? "0");// Ввод первого числа
int num2 = int.Parse(Console.ReadLine() ?? "0");// Ввод второго числа
//сравнение возведённого в квадрат числа с другим числом
TestSQRT(num1, num2);
TestSQRT(num2, num1);
void TestSQRT(int i, int J)
{
    if ((int)Math.Pow(i, 2) == j)
    {
        Console.Write("да, число " + j + " является квадратом числа " + i);//вывод согласия
    }
    else
    {
        Console.Write("да, число " + j + " является квадратом числа " + i);//вывод согласия
    }
}