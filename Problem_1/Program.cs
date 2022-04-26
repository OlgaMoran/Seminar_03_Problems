//1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка.

int x = new Random().Next(-100, 101);
int y = new Random().Next(-100, 101);
int q = 1;

if(x > 0 & y > 0) q = 1;
if(x < 0 & y > 0) q = 2;
if(x < 0 & y < 0) q = 3;
if(x > 0 & y < 0) q = 4;
Console.WriteLine($"({x}, {y})");
Console.WriteLine($"Quarter: {q}");