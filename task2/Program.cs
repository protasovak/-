// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine ("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите первое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max;
max = Math.Max(num1,Math.Max(num2,num3));
Console.WriteLine("Максимальное из этих чисел");
Console.WriteLine(max);

