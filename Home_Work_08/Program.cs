﻿/*Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
 элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/*
int[,] Random2dArray ()
{   
    Console.Write("Enter the minimum value of random range: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the maximum value of random range: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for (int j=0; j < columns; j++)
        {
            array [i,j] = new Random().Next(minVal, maxVal+1);
            
        }
    return array;
}

void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array [i,j] + "\t");  
        Console.WriteLine();
    }
 Console.WriteLine();   
}

int[,] OrderedArray (int[,] newArray)
{

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1) - 1; j++)
        {
            for (int x = 0; x < newArray.GetLength(1) - 1; x++)
            {
                if (newArray[i, x] < newArray[i, x + 1]) 
                {
                    int temp = 0;
                    temp = newArray[i, x];
                    newArray[i, x] = newArray[i, x + 1];
                    newArray[i, x + 1] = temp;
                }
            }
        }
    }
    return newArray;
}
int[,] newArray = Random2dArray();
Show2dArray(newArray);
Console.WriteLine("The ordered array is:");
OrderedArray(newArray);
Show2dArray(newArray);
*/

/*Задача 2.  Задайте прямоугольный двумерный массив. Напишите программу,
 которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
суммой элементов: 1 строка.
*/

int[,] Random2dArray ()
{   
    Console.Write("Enter the minimum value of random range: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the maximum value of random range: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the size of the square array: ");
    int index = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[index, index];
    for(int i = 0; i < index; i++)
        for (int j=0; j < index; j++)
        
            array [i,j] = new Random().Next(minVal, maxVal+1);
            
        
    return array;
}

void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array [i,j] + "\t");  
        Console.WriteLine();
    }
 Console.WriteLine();   
}

int GetMinSum (int[,] newArray)
{
int minsum = 0;
int indexRow = 1;

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        int sum = 0;
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                sum = sum + newArray[i, j];        
            }
            if (sum < minsum)
                {
                    minsum = sum;
                    indexRow++;
                }
    }
    return indexRow;
}

int[,] newArray = Random2dArray();
Show2dArray(newArray);
Console.WriteLine("The row with the smallest sum of elements is "+ GetMinSum(newArray));


/* Задача 3. Задайте две матрицы. Напишите программу, которая будет находить
 произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


/* Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/



/*Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/