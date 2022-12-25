/*Задача 1. Напишите программу, которая принимает на вход число и проверяет,
 является ли оно палиндромом.*/
/*
int result = 0;
int reversNumber (int number)
{   
    while (number > 0)
        {
           int reminder = number % 10;
            number = number / 10;
            result = result * 10 + reminder;
        }
    int finResult = result;
    return finResult;
}
 
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int oper = number;
    
    if (oper == reversNumber(number)) 
        Console.WriteLine("Your number is a palindrome.");
    else
        Console.WriteLine("Your number is not a palindrome.");
*/
        
        

/*Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит
  расстояние между ними в 3D пространстве.*/
/*
void distans3d(double x1, double x2, double y1, double y2, double z1, double z2)
{
  double distans = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)),2);
  Console.Write($"Distance between points = {distans}");
}

Console.WriteLine("Enter the coordinates of the first point");
Console.Write("x1 = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1 = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z1 = ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates of the second point");
Console.Write("x2 = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2 = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z2 = ");
double z2 = Convert.ToDouble(Console.ReadLine());
 distans3d(x1, x2, y1, y2, z1, z2);
*/


/*Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
  чисел от 1 до N.*/