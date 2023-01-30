//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

//Метод подсчета количество цифр
int SumDigit(int num)
{
    int res= 0;
    while(num>0)
    {
        res++;
        num = num/10;
    }
    return res;
}

int SumDigitStr(int num)
{
    int res = 0;
    res = num.ToString().Length;
    return res;
}

int VariantLog(int num)
{
    int count = (int)Math

}