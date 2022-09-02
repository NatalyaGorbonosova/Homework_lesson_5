// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int index = 0; index < length; index++) array[index] = new Random().Next(-10, 100);
    return array;
}
void PrintArray(int[] arr)
{
    foreach(int i in arr) Console.Write($"{i}, ");
    Console.WriteLine();
}
int SumOddIndex(int[] Array)
{
    int sum = 0;
    for(int i = 1; i < Array.Length; i+=2) sum+= Array[i];
    return sum;
}
try
{
    Console.Write("Введите количество элементов в массиве: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] array1 = new int[N];
    array1 = FillArray(N);
    PrintArray(array1);
    int result = SumOddIndex(array1);
    Console.WriteLine($"Сумма элементов массива, стоящх на нечётных позициях равна: {result}");
}
catch
{
    Console.WriteLine("Введите целые числа");
}

