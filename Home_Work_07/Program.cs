/*Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
double[,] Random2dArray (int rows, int columns, int minVal, int maxVal)
{
    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)
        for (int j=0; j < columns; j++)
        {
            array [i,j] = Math.Round (new Random().NextDouble () + new Random().Next(minVal, maxVal), 2);
            
        }
    return array;
}

void Show2dArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array [i,j] + "; ");
        Console.WriteLine();
    }
}

Console.Write("Enter the minimum value of random range: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum value of random range: ");
int maxVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] newArray = Random2dArray(rows, columns, minVal, maxVal);
Show2dArray(newArray);
*/

/*Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> элемента с такими индексами в массиве нет
*/


/*Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/