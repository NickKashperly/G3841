﻿
// char[]  digit  =Console.ReadLine().ToChartArer
//   Console.WriteLine(digit2);
// if(char[]length>3);
// else
// {
    
// }
////////////////
// 


//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()??"0");
//"Если значение более ста, то продолжаем, иначе выводим сообщение об ошибке"
if (number >= 100)
{
    //Уничтожаем хвостик после третьей цифры
    while (number > 999)
    {
        //Уничтожение последней цифры
        number = number / 10;
    }
    Console.WriteLine("третье число: ");
    //Выводим остаток от деления на 10( возвращаем последнюю цыфру)
    Console.WriteLine(number % 10);
}
else
{
    //Вывод ошибки
    Console.WriteLine("число не трёхзначное!");
}