// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

string RecLineMN( int n)
{
    if (n <= 1)
    {
        return n.ToString();
    }
    else
    
    {
        return n + " " + RecLineMN(n-1);
    }
}


// 1 - вызов
// string RecLineMN(10, 5)
// {
//     if (10 >= 5)
//     {
//         return 5.ToString();
//     }
//     else
//     {
//         return 5 + " " + 6 + " " + 7 + " " + 8 + " " + 9 + " " + 10;
//     }
// }
// 2 - вызов
// string RecLineMN(6, 10)
// {
//     if (6 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 6 + " " + 7 + " " + 8 + " " + 9 + " " + 10;
//     }
// }
// 3 - вызов
// string RecLineMN(7, 10)
// {
//     if (7 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 7 + " " + 8 + " " + 9 + " " + 10;
//     }
// }
// 4 - вызов
// string RecLineMN(8, 10)
// {
//     if (8 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 8 + " " + 9 + " " + 10;
//     }
// }
// 5 - вызов
// string RecLineMN(9, 10)
// {
//     if (9 >= 10)
//     {
//         return n.ToString();
//     }
//     else
//     {
//         return 9 + " " + 10;
//     }
// }
// 6 - вызов
// string RecLineMN(10, 10)
// {
//     if (10 >= 10)
//     {
//         return 10.ToString();
//     }
//     else
//     {
//         return m + " " + RecLineMN(m + 1, n);
//     }
// }




int numN = ReadData("Введите число N: ");
string res = RecLineMN(numN);
PrintResult(res);