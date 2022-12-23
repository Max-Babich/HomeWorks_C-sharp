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
      int answer = secondDigit(number); // with variables
      //Console.WriteLine ($"The second digit from your number is {answer}.");
      Console.WriteLine ($"The second digit from your namber is {secondDigit(number)}"); 
   }
   else
      Console.WriteLine ("Your number is not three-digit.");
*/
 

/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.*/




/*Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.*/