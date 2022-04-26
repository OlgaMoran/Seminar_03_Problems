// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.

// 1. ввод данных
// 2. ax, ay, bx, by
// 3. найти расстояние

int GetValue(string text)
{
    Console.Write($"{text}: ");
    string getValueStr = Console.ReadLine()!;
    int value = Convert.ToInt32(getValueStr);
    return value;
}

double Pythagor(int ax, int ay, int bx, int by)
{
    return Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));
}

int Ax = GetValue("Ax");
int Ay = GetValue("Ay");
int Bx = GetValue("Bx");
int By = GetValue("By");
double result = Pythagor(Ax, Ay, Bx, By);
Console.WriteLine(Math.Round(result, 2));