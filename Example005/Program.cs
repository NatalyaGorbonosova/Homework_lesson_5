// //Задача 21 HARD - необязательная
//Напишите программу, которая принимает на вход целое положительное число N и координаты двух точек
// и находит расстояние между ними в N-мерном пространстве.
double Distant3D(double [] arrayA, double [] arrayB) //Находит расстояние между точками
{
    double sum = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
        sum = sum + Math.Pow(arrayB[i] - arrayA[i], 2);
    }
    double dist = Math.Sqrt(sum);
    return Math.Round(dist, 2);
}
double[] FillArray(int length)
{
    double[] array = new double[length];
    for(int index = 0; index < length; index++) array[index] = Convert.ToDouble(Console.ReadLine());
    return array;
}
try
{ 
Console.WriteLine("Введите размерность пространства: ");
int N = Convert.ToInt32(Console.ReadLine());
double [] ArrayPointA = new double [N];
Console.WriteLine("Введите координаты точки А: ");
ArrayPointA = FillArray(N);

double [] ArrayPointB = new double [N];
Console.WriteLine("Введите координаты точки B: ");
ArrayPointB = FillArray(N);

Console.WriteLine("Расстояние между точками равно: " + Distant3D(ArrayPointA, ArrayPointB));
}
catch
{
    Console.WriteLine("При введении координат используйте числа!!!");
}

