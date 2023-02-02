/*Задача 1. Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

/*
int m = 7;
int count = 0;
for (int i=1; i<=m; i++)
{
Console.Write($"Enter {i} namber out of {m}: ");
int num = Convert.ToInt32(Console.ReadLine());
    if (num>0) count++;
}
Console.WriteLine($"Numbers greater than zero {count}.");
*/

/*Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

/*
Console.Write("Enter the number b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the number k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the number b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the number k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"The lines will intersect at the point with the coordinates X= {x}, Y= {y}");
*/