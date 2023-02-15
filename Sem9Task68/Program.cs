// Задача 68: Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(long prefix)
{
    Console.WriteLine(prefix);
}

long RecAckermann(long m, long n)
{
    // if (m >= n)
    // {
    //     return n.ToString();
    // }
    // else
    // {
    //     return m + " " + RecLineMN(m + 1, n);
    // }


    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return RecAckermann(m - 1, 1);
    if (n > 0 && m > 0) return RecAckermann(m - 1, RecAckermann(m, n - 1));
    return RecAckermann(n, m);
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




long numM = ReadData("Введите число M: ");
long numN = ReadData("Введите число N: ");
long res = RecAckermann(numM, numN);
PrintResult(res);