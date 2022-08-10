//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

public enum DayOfWeek
{
    Понедельник = 0,Вторник = 1,Среда =2,Четверг = 3,Пятница = 4,Суббота = 5,Воскресенье = 6
}
class Program
{
public static void Main(string[]args)
{
    Console.WriteLine("введите число от 1 до 7");
    var n = int.Parse(Console.ReadLine());
    if (n<6)
    {
      Console.WriteLine((DayOfWeek)((n - 1) % Enum.GetValues(typeof(DayOfWeek)).Length));  
    }
    
    else if (n>=6 && n<=7)
    {
        Console.WriteLine((DayOfWeek)((n - 1) % Enum.GetValues(typeof(DayOfWeek)).Length));
        Console.WriteLine("выходной");
    }
    else
    {
        Console.WriteLine("введено неверное число");
    }
    
}
}
