// Задача 43: Напишите программу, которая найдёт точку
//  пересечения двух прямых, заданных уравнениями
//   y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//   задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// (от Голикова А.С.) * Найдите площадь треугольника образованного
//  пересечением 3 прямых

//1) Проверяем входящее число
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод поиска координат точки пересечения
void KoordinPoint(double b1, double k1, double b2, double k2)
{
    //k1*x+b1=k2*x+b2  => k1*x-k2*x= b2-b1 =>x=(b2-b1)/(k1-k2)
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine("Координаты точки пересечения " + "(" + x + "; " + y + ")");

}
// int[] testArr = Gen1DArray(123, 100, 999);
// Print1DArr(testArr);
// int count = SumPos(testArr);
// PrintData("Cумма нечетных элементов массива:" + count);

//2) Вводим координаты точек с клавиатуры
double b1 = ReadData("Введите коэффициен b1: ");
double k1 = ReadData("Введите коэффициен k1: ");
double b2 = ReadData("Введите коэффициен b2: ");
double k2 = ReadData("Введите коэффициен k2: ");
KoordinPoint(b1, k1, b2, k2);
