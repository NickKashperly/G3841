Console.WriteLine("Введите первое число: ");
string? firstNumber = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string? secondNumber = Console.ReadLine();
Console.WriteLine("Введите третье число: ");
string? thirdNumber = Console.ReadLine();

if (firstNumber != null && secondNumber != null && thirdNumber != null)
{
    int first = int.Parse(firstNumber);
    int second = int.Parse(secondNumber);
    int third = int.Parse(thirdNumber);

    if (first > second)
    {
        if (first > third)
        {
            Console.Write("Максимальное число: ");
            Console.Write(first);
        }
        else
        {
            Console.Write("Максимальное число: ");
            Console.Write(third);

        }
    }
    else
    {
        if (second > third)
        {
            Console.Write("Максимальное число: ");
            Console.Write(second);
        }
        else
        {
            Console.Write("Максимальное число: ");
            Console.Write(third);
        }
    }
}
