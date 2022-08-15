/*
Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

//int x=3;
//int y=5;

Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

void Degree(int x,int y)
{
double pow = Math.Pow(x,y);
Console.WriteLine($"Степень числа {x} в степени {y}" );
Console.WriteLine(pow);
}
Degree(x,y);
