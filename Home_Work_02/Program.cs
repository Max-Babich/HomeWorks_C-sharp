/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.*/
/*
 int secondDigit (int number)
 {
    //int interim = number%100;
    //int result = interim/10;
    //return result;
    return number%100/10;  // without variables
 }

 Console.Write("Enter the three-digit number: ");
 int number  = Convert.ToInt32(Console.ReadLine());
   if (number<1000 && number>99) 
   {
      //int answer = secondDigit(number); // with variables
      //Console.WriteLine ($"The second digit from your number is {answer}.");
      Console.WriteLine ($"The second digit from your namber is {secondDigit(number)}"); 
   }
   else
      Console.WriteLine ("Your number is not three-digit.");
*/
 

/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.*/
/*
int cutNumber(int number)
{
   while (number >= 1000)
      {
         number = number/10;
      }
   int result = number%10;
   return result;

}
Console.Write("Enter the number: ");
int number = Convert.ToInt32 (Console.ReadLine());
   
   if (number>99)
      {
         int answer = cutNumber(number);
         Console.Write($"The third digit of the left is {answer}.");   
      }   
   else
      Console.Write("There is no third digit in the number");
*/      
         
         
/*Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.*/
/*
 bool day (int num)
 {
   if (num==7 || num==6)
   return true;
   else 
   return false;
 }
Console.Write("Enter the number of the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());
if (day(num)==true)
   Console.WriteLine("it's a day off");
else
   Console.WriteLine("It's a working day");
*/