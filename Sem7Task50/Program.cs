// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру


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
            inputArray[i, j] = new Random().Next(0, 16);
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

int num = ReadData("Какое целое число найти: ");
SearchElem(matrix, num);
//метод для поиска указанного числа
void SearchElem(int[,] inputArray, int num)
{
    bool numfind = false;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (num == inputArray[i, j])
            {
                Console.Write("Число " + num + " найдено в позиции" + " [" + i + "," + j + "]; ");
                numfind = true;
            }
           
        }
    }
     if (numfind == false)
            {
                Console.WriteLine("Число " + num + " не найдено!!!");
            }

}
