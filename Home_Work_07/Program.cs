/*Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
double[,] Random2dArray ()
{   
    Console.Write("Enter the minimum value of random range: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the maximum value of random range: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

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
            Console.Write(array [i,j] + "\t");  
        Console.WriteLine();
    }
 Console.WriteLine();   
}

double[,] newArray = Random2dArray();
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

double[,] Random2dArray ()
{   
    Console.Write("Enter the minimum value of random range: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the maximum value of random range: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the numbers of rows in the array: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the numbers of columns in the array: ");
    int columns = Convert.ToInt32(Console.ReadLine());

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
            Console.Write(array [i,j] + "\t");  
        Console.WriteLine();
    }
 Console.WriteLine();   
}

double[,] newArray = Random2dArray ();
Show2dArray(newArray);
Console.Write("Input the number of row: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of column: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n > newArray.GetLength(0) || m > newArray.GetLength(1))
    Console.WriteLine("There is no such element.");
else
    Console.WriteLine($"The value of the row {n} and column {m} element is {newArray[n-1,m-1]}.");


/*Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/