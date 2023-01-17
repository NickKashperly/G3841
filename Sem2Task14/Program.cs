int num1 = int.Parse(Console.ReadLine()??"0");

int res1 = num1%7;
int res2 = num1%23;
if(res1 == 0  &&  res2 == 0)
{
    Console.WriteLine("Кратно");

}
else
{
    Console.WriteLine("Некратно");
}