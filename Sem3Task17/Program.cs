//Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

int coordX = ReadData("Введите координату  X");
int coordY = ReadData("Введите координату  Y");
PrintQuterTest();

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод определяет четверт по координатам точки
void PrintQuterTest()
{
    if (coordX > 0 && coordY > 0) Console.WriteLine("Точка в первой четверти");
    if (coordX > 0 && coordY < 0) Console.WriteLine("Точка во второй четверти");
    if (coordX < 0 && coordY < 0) Console.WriteLine("Точка в третей четверти");
    if (coordX < 0 && coordY > 0) Console.WriteLine("Точка в четвертой четверти");
}


