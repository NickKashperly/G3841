Console.WriteLine("Введите первое число: ");
string? firstNumber = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string? secondNumber = Console.ReadLine();

if (firstNumber != null && secondNumber != null)
{
    int firstNum = int.Parse(firstNumber);


    int secondNum = int.Parse(secondNumber);



    if (firstNum > secondNum)
    {
        Console.Write("Число: ");
        Console.Write(firstNum);
        Console.Write(", больше числа: ");
        Console.Write(secondNum);
    }
    else
    {
        Console.Write("Число: ");
        Console.Write(secondNum);
        Console.Write(", больше числа: ");
        Console.Write(firstNum);

    }


}