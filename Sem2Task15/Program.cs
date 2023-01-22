int day = int.Parse(Console.ReadLine()??"0");

if(day >7  && day <1)
{
    Console.WriteLine("Это не день недели'");

}

if(day>5)
    {
    Console.WriteLine("Выходной");
    }
else
   {
    Console.WriteLine("Рабочий день");
   }

// Dictionary C# ключ/значение;