/*Напишите программу, которая принимает 
на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


class Program
{
static void Main(string[]args)
{
    int number = 0;
    while (true)
    {
        Console.WriteLine("Введите число");
        if(int.TryParse(Console.ReadLine(), out number))
           break;
        else
            Console.WriteLine("неверное число");   
    }
    int oldValue = number;
    int newValue = 0;
    while (number > 0)
    {
        int dig = number % 10;
        newValue = newValue * 10 + dig;
        number=number / 10;
    }
    if(newValue==oldValue)
       Console.WriteLine("Палиндром");
    else
        Console.WriteLine("не палиндром");
        
}
}