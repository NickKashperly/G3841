// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07





// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив по спирале
int[,] Gen2DArray(int n)
{
    int[,] matr = new int[n, n];
    int temp =1;
    int i=0;
    int j=0;
    while (temp <= matr.GetLength(0)*matr.GetLength(1))
    {
        matr[i,j]= temp;
        temp++;
        if(i<=j+1 && i+j<matr.GetLength(1)-1) j++;
        else if (i< j && i+j >=matr.GetLength(0)-1) i++;
        else if (i>= j && i+j > matr.GetLength(0)-1) j--;
        else i--;
    }
    // for (int i = 0; i < matr.GetLength(0); i++)
    // {
    //     for (int j = 0; j < matr.GetLength(1); j++)
    //     {
    //         matr[i, j] = new Random().Next(min, max + 1);
    //     }
    // }
    return matr;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}




int n = ReadData("Введите количество строк и столбцов матрицы N: ");
int[,] matrix = Gen2DArray( n);
Print2DArray(matrix);


