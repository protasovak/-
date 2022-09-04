/*
адайте значения M и N. Напишите программу, которая найдёт сумму чётных чисел натуральных 
элементов в промежутке от M до N.

M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/


Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

int sumResult = 0;

for (int i = m; i <= n; i++)
{
    if (i % 2 == 0)
    {
        sumResult += i;
    }
    
}
Console.WriteLine($"Сумма четных натуральных чисел в промежутке от m до n: {sumResult}");