// Задача №32
// Напишите программу замена элементов массива: положительные элементы замените
//  на соответствующие отрицательные, и наоборот.

int[] Gen1DArr(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]+"]");
}

void InvArr(int[] arr)
{
    for(int i=0;i<arr.Length;i++)
    {
        arr[i]*=-1;
    }
}

int[] InvArrNew(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for(int i=0;i<arr.Length;i++)
    {
       newArr[i] = arr[i]*-1;
    }
    return newArr;
}


int[] testArr = Gen1DArr(12,-9,9);
Print1DArr(testArr);
InvArr(testArr);
int[] testArrNew = InvArrNew(testArr);
Print1DArr(testArr);

