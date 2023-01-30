// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
// * Отсортируйте массив методом вставки и методом подсчета,
//  а затем найдите разницу между первым и последним элементом.
// Для задачи со звездочкой использовать заполнение массива целыми числами.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

double[] Gen1DArray(int len, double minValue, double maxValue)
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble() * ((maxValue + 1.0) - minValue);
    }
    return arr;
}

void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

double CountElem(double[] arr)
{
    double res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i]))
        {
            res++;
        }
    }
    return res;
}

// int MinMax(int[] arr)
// {
//     int max = int.MinValue;
//     int min = int.MaxValue;

//     for(int i=0; i<arr.Length; i++ )
//     {
//         if (arr[i]> max) max =arr[i];
//         if (arr[i]<min) min = arr[i];
//         return (max-min);
//     }
// }

double MinMax(double[] arr)
{
    double max = double.MinValue;
    double min = double.MaxValue;

    for (int i = 0; i < arr.Length; i++ )
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return (max - min);
}

bool Test(double n)
{
    return (n > 10 && n < 99);
}

double[] testArr = Gen1DArray(123, 1.8, 90.9);
Print1DArr(testArr);
double count = CountElem(testArr);

// double[] array = Gen1DArray(123, 1.8, 90.9);
// Print1DArr(array);
double mima = MinMax(testArr);
PrintData("Разница между минимум и максимум:" + mima);
PrintData("Количество элементов в отрезке [10,99] :" + count);