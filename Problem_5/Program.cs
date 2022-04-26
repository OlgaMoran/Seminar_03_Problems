//Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

int GetValue(string text)
{
    Console.Write($"{text}: ");
    string getValueStr = Console.ReadLine()!;
    int value = Convert.ToInt32(getValueStr);
    return value;
}

double DistanceIn3D(int ax, int ay, int az, int bx, int by, int bz)
{
    return Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
}

int Ax = GetValue("Ax");
int Ay = GetValue("Ay");
int Az = GetValue("Az");
int Bx = GetValue("Bx");
int By = GetValue("By");
int Bz = GetValue("Bz");
double result = DistanceIn3D(Ax, Ay, Az, Bx, By, Bz);
Console.WriteLine(Math.Round(result, 2));