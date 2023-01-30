/* Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

/*
int[] RandomArray (int size, int minVal = 100, int maxVal = 1000)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    
        array [i] = new Random().Next (minVal, maxVal);
    return array;
}

void EvenCount (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        Console.Write(array [i] + " ");
        int result = array[i]%2;
        if (result == 0) count++;

    }
    Console.WriteLine();
    Console.Write($"There is {count} even numbers in the array.");
}
Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = RandomArray(size);
EvenCount(newArray);
*/

/* Задача 2.Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


int[] RandomArray (int size, int minVal, int maxVal)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array [i] = new Random().Next (minVal, maxVal+1);
        Console.Write(array [i] + " ");
    }
    Console.WriteLine();
    return array;
}

void OddPositionSum (int[] array)
{
    int sum = 0;
    for (int i =1; i < array.Length; i+=2)
        sum +=array[i];
    Console.Write($"Sum of odd array elements is {sum}");
}

Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum value of the array: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum value of the array: ");
int maxVal = Convert.ToInt32(Console.ReadLine());
int[] newArray = RandomArray(size, minVal, maxVal);
OddPositionSum(newArray);



/* Задача 3. Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

/*
int[] RandomArray (int size, int minVal, int maxVal)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array [i] = new Random().Next (minVal, maxVal+1);
        Console.Write(array [i] + " ");
    }
    Console.WriteLine();
    return array;
}
int GetDiff(int[] array)
{
    int maxNum = 0;
    for (int i = 0; i < array.Length; i++)
    if (maxNum < array[i]) maxNum = array[i];
    int minNum = maxNum;
    for (int i = 0; i < array.Length; i++)
    if (minNum > array[i]) minNum = array[i];
    int diff = maxNum - minNum;
    return diff;
}

Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum value of random range: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum value of random range: ");
int maxVal = Convert.ToInt32(Console.ReadLine());
int[] newArray = RandomArray(size, minVal, maxVal);
Console.Write($"The difference between the minimum and maximum values of the array is {GetDiff (newArray)}.");
*/