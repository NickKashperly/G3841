// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
int[,,] Gen3DArray(int raw, int col, int dep, int min, int max)
{
    int[,,] matr = new int[raw, col, dep];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = new Random().Next(min, max + 1);
            }
        }
        
    }
    return matr;
}
// Печать трехмерного массива
void Print3DArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}" + (i,j,k));
                Console.Write("  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int p = ReadData("Введите количество рядов P: ");
int[,,] matrix = Gen3DArray(m, n, p, 10, 99);
Print3DArray(matrix);




