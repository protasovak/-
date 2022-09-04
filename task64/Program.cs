/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
промежутке от M до N от большего к меньшему.

M = 1; N = 5. -> ""5, 4, 3, 2, 1""

M = 4; N = 8. -> ""8, 7, 6, 5, 4""
*/

Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = m; i >= n; i--)
{
    Console.Write($"{i}  ");
}
    
Console.WriteLine();
