// // Напишите программу, которая принимает на вход число (N) 
// // и выдаёт таблицу квадратов чисел от 1 до N.

int GetNum(string text)
{
    Console.Write($"{text}: ");
    string getNumStr = Console.ReadLine()!;
    int number = Convert.ToInt32(getNumStr);
    return number;
}

int N = GetNum("N");
for (int i = 1; i <= N; i++)
{
    double sqr = Math.Pow(i, 2);
    Console.WriteLine(sqr);
}