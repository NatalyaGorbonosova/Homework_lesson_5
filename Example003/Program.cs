// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] FillArray(int length)
{
    double[] array = new double[length];
    Console.WriteLine("Введите элементы массива");
    for(int index = 0; index < length; index++) array[index] = Convert.ToDouble(Console.ReadLine());
    return array;
}
void PrintArray(double[] arr)
{
    foreach(double i in arr) Console.Write($"{i}, ");
    Console.WriteLine();
}
double FindRange(double[] Array)
{
    double Max = Array[0];
    double Min = Array[0];
    for(int i = 1; i < Array.Length; i++)
    {
        if(Array[i] > Max) Max = Array[i];
        if(Array[i] < Min) Min = Array[i];
    }
    Double range = Max - Min;
    return range;
}
try
{
    Console.Write("Введите количество элементов в массиве: ");
    int N = Convert.ToInt32(Console.ReadLine());
    double[] array1 = new double[N];
    array1 = FillArray(N);
    PrintArray(array1);
    double result = FindRange(array1);
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна: {result}");
}
catch
{
    Console.WriteLine("Введите числа через запятую");
}

