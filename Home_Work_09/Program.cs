/*Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа
 в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/*
void NaturalNum(int number)
{
    if (number > 1)
    {
        Console.Write(number + ", ");
        NaturalNum(number - 1);
    }
    else Console.Write(number);   
}
int inputNum(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
NaturalNum(inputNum("Please, Input Number "));
*/

/*Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
 в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
int SumInterval(int n, int m)
{
    if (n > m) return m + SumInterval(n, m + 1);
    if (m > n) return n + SumInterval(n + 1, m);
    else return n;
}
int inputNum(string message)
{
    Console.Write(message + ": ");
    return int.Parse(Console.ReadLine());
}
Console.WriteLine(SumInterval(inputNum("Input the first number: "), inputNum("Input the second number: ")));
*/

/*Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

/*
Console.WriteLine("Enter two positive numbers: M and N.");
int m = InputInt("Enter M: ");
int n = InputInt("Enter N: ");
Console.WriteLine($"A({m}, {n}) = {AckerFun(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int AckerFun(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return AckerFun(m - 1, 1);
    else
        return AckerFun(m - 1, AckerFun(m, n - 1));
}
*/