Console.WriteLine("Введите число: ");
string? firstNumber = Console.ReadLine();


if (firstNumber != null)
{
    int countN = int.Parse(firstNumber);

    string result = string.Empty;
    for (int i = 2; i < countN; i = i + 2)
    {

        result = result + i + ",";

    }
    if (countN % 2 == 0)
    {
        result = result + countN;

    }
    Console.WriteLine(result);




}