/*    Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число
 A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
int getPow(int firstNum, int secondNum)
{
    int pow =1;
    for (int current=1; current<=secondNum; current++)
    pow*=firstNum;
    return pow;
}
Console.Write("Input the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The {a} to the {b} power is {getPow(a,b)}.");
*/

/* Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
int getSum (int num)
{
    int sum=0;
    
    while (num > 0 )
    {
        int cur=num%10;
        sum +=cur;
        num=num/10;
    }
    return sum;
}
Console.Write("Enter the number: ");
int num =Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of the digits in your number is {getSum(num)}.");
*/

/* Задача 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/*
int[] CreateArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input the {i+1} element of array:");
        array [i] = Convert.ToInt32(Console.ReadLine());

    }
    return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array [i] + ", ");
    Console.WriteLine();
    
}

Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateArray(size);
ShowArray(newArray);
*/
