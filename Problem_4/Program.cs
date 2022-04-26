// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

int n = 45854;
if ((n / 10000) == (n % 10) & (n / 1000 % 10) == (n / 10 % 10)) Console.WriteLine("palindrom");
else Console.WriteLine("not palindrom");