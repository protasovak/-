/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

 void SumOfDigits()
    {
        Console.Write("Введите число: ");
 
        int startDigit = Convert.ToInt32(Console.ReadLine());
        int digit = startDigit;
        int result = 0;
 
        while (digit>0)
        {
            result += digit % 10;
            digit = digit / 10;
        }
        Console.WriteLine($"сумма цифр в числе {startDigit} равна {result}");
    }
 
SumOfDigits();