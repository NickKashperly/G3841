//Задача 27: 
//Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(int msg1)
{
    Console.WriteLine(msg1);

}

// //Метод подсчета количество цифр
// string Pow(int x, int y)
// {
//     string res = -1;
//     res = Math.Pow(x, y);
//     return res;
// }
int numA = ReadData("Введите число: ");

int num = SumSym(numA);
PrintData(num);

int SumSym(int numA)
{
    int res = 0;
        while (numA>0)
        {
            res = res + numA%10;
            numA=numA/10;
        }
    return res;
}

