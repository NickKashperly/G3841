Console.WriteLine("Введите число: ");
string? firstNumber = Console.ReadLine();


if (firstNumber != null)
{
    int first = int.Parse(firstNumber);


    if (first % 2 == 0)
    {

        Console.Write("Число: ");
        Console.Write(first);
        Console.Write(" - четное ");
    }
    else
    {

        Console.Write("Число: ");
        Console.Write(first);
        Console.Write(" - не четное ");
    }
}
