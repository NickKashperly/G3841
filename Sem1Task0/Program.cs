// Задача 1
// Проверяем является ли первое число квадратом второго
// Считываем данные с консоли
string? inputNum1 = Console.ReadLine();
// Считываем данные с консоли
string? inputNum2 = Console.ReadLine();
if (inputNum1!=null && inputNum2!=null)
{
   //Парсим введенное число
int number1 = int.Parse(inputNum);
//Парсим введенное число
int number2 = int.Parse(inputNum);
  

   if(number1 == number2*number2)
   {
    Console.WriteLine("Первое число квадрат второго!");
   }
   else
   {
     Console.WriteLine("Первое число не квадрат второго!");

   }



?

// //Проверяем, чтобы данные были не пустыми
// if (inputNum1 != null && inputNum2 != null)
// {
//     //Парсим введенное число
//     int number1 = int.Parse(inputNum1);
//     //Парсим введенное число
//     int number2 = int.Parse(inputNum2);

//     // if(number1==number2*number2)
//     // {
//     //     Console.WriteLine("Первое число квадрат второго!");
//     // }
//     // else
//     // {
//     //     Console.WriteLine("Первое число не квадрат второго!");
//     // }



// }
