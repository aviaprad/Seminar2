
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
/*
int SecondDigit(int number)
{
    int number1 = number / 10;   // отсекаем 3-ю цифру
    int second_digit = number1 % 10;    // находим вторую цифру как остаток от деления на 10 двухзначного числа
  
    return second_digit;
}

Console.WriteLine("Input your 3 digit number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

int result = SecondDigit(user_number);

Console.WriteLine($"Second digit is: {result}");
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
int ThirdDigit(int number)  // метод определения 3-й цифры
{
    if (number<0)
      number = number *(-1);
     while (number >=1000)
     {
      number = number/10;
     }
     
    int result = number % 10;
    return result;
}

Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ( number > - 100 && number < 100)
   {
      Console.WriteLine("The third digit is missing");
   } 
   else
   {
       int digit3 = ThirdDigit(number);
       Console.WriteLine($"Third digit is: {digit3}");
   }
*/


/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

void WheeklyDay(int number) // невозвратная функция определения выходных дней в неделе
{
if (number >= 6  && number <=7 )
{
  Console.WriteLine("Это выходной день");
}
  
   else
   {
      Console.WriteLine("Это рабочий день");
   }
}

Console.WriteLine ("Введите день недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

WheeklyDay(number);

