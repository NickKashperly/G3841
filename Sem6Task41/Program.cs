// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// (от Голикова А.С.) * Пользователь вводит число нажатий,
//  затем программа следит за нажатиями с клавиатуры и выдает
//   сколько чисел больше 0 было введено.
// Выводим массив введеных чисел
void show1DArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(" ");
}

// переводим string в double
double[] multiInputs(string msg)
{
    Console.Write(msg);
    string n = Console.ReadLine() ?? "0";
    string[] arr = n.Split(";");
    double[] vec = { };
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] != ""))
            vec = vec.Append(double.Parse(arr[i])).ToArray();
    }
    return vec;
}


Console.WriteLine();

//Считаем количество отрицательных чисел
int countMinus(double[] arr )
{
    int num = 0;
     for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <0)
        {
          num=num+1;
        }   
    }
    return num;
}
//Вызываем перевода из строки в массив
double[]vec = multiInputs("Введите числа в одну строку через точку с запятой " +"(;)"+ "  : ");
show1DArray(vec);
//Вызываем третий метод
int num = countMinus(vec);
 Console.WriteLine("Количество отрицательных чисел равно: "+ num);


