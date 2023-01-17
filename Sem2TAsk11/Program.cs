Random numSintezator = new Random();
int num = numSintezator.Next(100,1000);
Console.WriteLine(num);
int digitFirst = num/100;
int digitLast= num%10;
Console.WriteLine(digitFirst*10+digitLast);

