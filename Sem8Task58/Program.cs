// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
int[,] Gen2DArray(int raw, int col, int min, int max)
{
    int[,] matr = new int[raw, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
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
int [,] СompositionArr(int[,] arrA, int[,] arrB)
{
            if (arrA.GetLength(1) != arrB.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] compos = new int[arrA.GetLength(0), arrB.GetLength(1)];
            for (int i = 0; i < arrA.GetLength(0); i++)
            {
                for (int j = 0; j < arrB.GetLength(1); j++)
                {
                    for (int k = 0; k < arrB.GetLength(0); k++)
                    {
                        compos[i,j] += arrA[i,k] * arrB[k,j];
                    }
                }
            }
            return compos;
        }



int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrixA = Gen2DArray(m, n, 0, 100);
Print2DArray(matrixA);
Console.WriteLine();
int[,] matrixB = Gen2DArray(m, n, 0, 100);
Print2DArray(matrixB);
Console.WriteLine();
int[,] matrixC = СompositionArr(matrixA, matrixB);
Print2DArray(matrixC);



