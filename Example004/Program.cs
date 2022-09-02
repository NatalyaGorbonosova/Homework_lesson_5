//Задача 19 HARD - необязательная
//Напишите программу, которая принимает на вход любое число и проверяет, является ли оно палиндромом.
string CheckPalindrom(string num)
{
    int length = num.Length;
    int x = Convert.ToInt32(num);
    string answer = "";
    for(int i = 0; i < length/2; i++)
    {
        int x1 = (x/(Convert.ToInt32(Math.Pow(10, length - 1 - i))))%10;
        int x2 = (x/(Convert.ToInt32(Math.Pow(10, i))))%10;
        if(x1 == x2) answer = "Yes";
        else
        {
            answer = "No";
            break;
        }
    }
    return answer;
}
try
{
    Console.Write("Введите число: ");
    string str = Console.ReadLine();
    Console.WriteLine(CheckPalindrom(str));
}
catch
{
    Console.WriteLine("Введите цело число!");
}
