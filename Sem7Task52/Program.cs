// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям 
// и диагональ выделить разным цветом.

//1) Получение данных от пользователя
int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество строк матрицы: ");

//2) Генерация двумерного массива
int[,] matrix = Fill2DArray(n, m);

//3) Печатаем двумерный массив
Print2DArray(matrix);

//4) Проверяем введенные данные
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод для заполнения двумерного массива
int[,] Fill2DArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;
}


//метод для печати двумерного массива
void Print2DArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            inputArray[i, j] = new Random().Next(10, 100);
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}


//метод поиска среднего арифметического в каждом столбце
double[] MeanColom(int[,] inputArray)
{
   double[] means = new double[inputArray.GetLength(1)];
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        for (int j = 0; j < inputArray.GetLength(0); j++)
        {
            means[i] += inputArray[j, i];
        }
        means[i] = means[i] / inputArray.GetLength(0);
        means[i] = Math.Round(means[i],2);
    }
    return means;
}

// Метод печати одномерного массива 
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + "; ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

Console.WriteLine();
// int []means = MeanColom(matrix);
// Print1DArr(means);

//Выводи на печать среденее арифметическое
Print1DArr(MeanColom(matrix));
