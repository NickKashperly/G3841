int ReadData(string msg);
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()?? "0");

}

void PrintData(string msg, double res)
{
    Console.WriteLine(msg+res);

}

double Calclen(int x1, int x2, int y1 , int y2, int x3, int y3)
{
    double res=0;
    res = Math.Sqrt(Math.Pow(x1=x2, 2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
    return res;
