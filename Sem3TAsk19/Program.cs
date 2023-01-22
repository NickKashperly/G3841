Console.Write("Введите пятизначное число: ");

int ReadData(string msg);
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()?? "0");

}


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
PrintData("Расстояние между точками:", PalinTest);




int ReadData(string msg);
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()?? "0");

}

void PrintData(string msg, double res)
{
    Console.WriteLine(msg+res);

}

double Calclen(int x1, int x2, int y1 , int y2)
{
    double res=0;
    res = Math.Sqrt(Math.Pow(x1=x2, 2)+Math.Pow(y1-y2,2));
    return res;

}

int coordX1 = ReadData("Введите координату x1");
int coordX2 = ReadData("Введите координату x2");
int coordY1 = ReadData("Введите координату y1");
int coordY2 = ReadData("Введите координату y2");

double len= Calclen(coordX1, coordX2, coordY1, coordY2);

PrintData("Расстояние между точками:", len);

