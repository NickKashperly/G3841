//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()?? "0");

}



// вычисляем палиндром или не палиндром
bool PalinTest(int n)
{
    bool res =false;
    int d1 = n/10000;
    int d2 = (n/1000)%10;
    int d3  = (n/10)%10;
    int d4 = n%10;
    res =((d1==d4) && (d2==d3))? true: false;
    return res;
}


//Выводим результат пользователю
void PrintData(string msg, bool res)
{
    Console.WriteLine(msg+res);

}

//Вводим пятизначное число
int number5 = ReadData("Введите пятизначное число");

//Вызов метода(определения палиндрома)
bool len = PalinTest(number5);

//Выдаем результат
PrintData("Данное число палиндром:", len);

