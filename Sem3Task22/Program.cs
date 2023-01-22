// //Задача №22
// //Напишите программу, которая принимает на вход число (N) 
// //и выдаёт таблицу квадратов чисел от 1 до N.

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// //Выводим результат пользователю
// void PrintData(string msg1, string msg2)
// {
//     Console.WriteLine(msg1);
//     Console.WriteLine(msg2);
// }

// string LineBuilder(int n, int p)
// {
//     string res = string.Empty;
//     for (int i = 1; 1 <= n; i++)
//     {
//         res += Math.Pow(i, p).ToString() + "\t";

//     }
//     return res;

// }

// //Ввод данных
// int num = ReadData("ВВедите N: ");

// //Собираем первую строчку таблицы 
// string line1 = LineBuilder(num, 1);
// //Собираем вторую строчку таблицы 
// string line2 = LineBuilder(num, 2);

// //Вывод данных

// PrintData(line1, line2);






// Задача №22!!!!!!!!
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 
// Ввод данных
Console.Write("Введите N: ");
int num = int.Parse(Console.ReadLine() ?? "0");

// вывод нахождения степени чисел от 1 до N
string LineBuilder(int n, int p)
{
    string res = "";
    for (int i = 1; i < n; i++)
    {
        res += Math.Pow(i, p).ToString() + "\t ";

    }
    return res;
}  

// Вывод данных
Console.WriteLine(LineBuilder(num, 1));
// Вывод данных
Console.WriteLine(LineBuilder(num, 2));