int num1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine(num1);
int num2 = int.Parse(Console.ReadLine()??"0");
int res = num2%num1;
if(res ==0)
{
    Console.WriteLine("Кратно");

}
else
{
    Console.WriteLine("Некратно"+res);
}