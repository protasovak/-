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
        Console.WriteLine(dig);
        newValue = newValue * 10 + dig;
        Console.WriteLine(newValue);
        number=number / 10;
        Console.WriteLine(number);
    }
    if(newValue==oldValue)
       Console.WriteLine("Палиндром");
    else
        Console.WriteLine("не палиндром");
        
}
}