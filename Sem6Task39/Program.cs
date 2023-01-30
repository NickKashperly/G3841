double[] Gen1DArray(int len, double minValue, double maxValue)
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble() * ((maxValue + 1.0) - minValue) ;
    }
    return arr;
}

void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}



double[] testArr = Gen1DArray(20, 1, 10);
Print1DArr(testArr);
