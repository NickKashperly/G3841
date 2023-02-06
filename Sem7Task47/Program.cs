// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

// Задача №46
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.








// Синтезатор цвета( черный исключим для аккуратного отображения в терминале  )
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

//1) Получение данных от пользователя
int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество строк матрицы: ");

//2) Генерация двумерного массива
double[,] matix = Fill2DArr(n,m);

//3) Печатаем двумерный массив
Print2DArr(matix);

//4) Проверяем корректность введенных данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// метод для заполнения двумерного массива
double[,] Fill2DArr(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    double[,] outArr = new double[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArr[i, j] = numberSyntezator.Next(10, 99)+ numberSyntezator.NextDouble();
            outArr[i,j] =Math.Round(outArr[i,j],2);
            j++;
        }
        i++;
    }
    return outArr;
}



//метод для печати двумерного массива
void Print2DArr(double[,] inputArr)
{
    int i = 0; int j = 0;

    while (i < inputArr.GetLength(0))
    {
        j = 0;
        while (j < inputArr.GetLength(1))
        {
            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(1,16));
            //col[new System.Random().Next(0,16)]  (убрали первый цвет "0" черный); 
            Console.Write(inputArr[i, j] + " ");
            Console.ResetColor(); 
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}


