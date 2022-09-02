// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int index = 0; index < length; index++) array[index] = new Random().Next(100, 1000);
    return array;
}
void PrintArray(int[] arr)
{
    foreach(int i in arr) Console.Write($"{i}, ");
    Console.WriteLine();
}
int CountEven (int[] Array)
{
    int count = 0;
    for(int i = 0; i < Array.Length; i++)
    {
        if(Array[i]%2 == 0) count++;
    }
    return count;
}
try
{
    Console.Write("Введите количество элементов в массиве: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] array1 = new int[N];
    array1 = FillArray(N);
    PrintArray(array1);
    int result = CountEven(array1);
    Console.WriteLine($"Количество четных чисел в масииве равно: {result}");
}
catch
{
    Console.WriteLine("Введите целые числа");
}
