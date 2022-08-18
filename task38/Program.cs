/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/

double[] arr = new double[5];

double MinElement = 0;
double MaxElement = 0;
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Math.Round(rnd.NextDouble()*10, 2);
    Console.Write($"{arr[i]} ");
    if (arr[i]>MaxElement)
    {
        MaxElement = arr[i];
    }
    if ( arr[i]<MinElement)
    {
        MinElement = arr[i];
    }
    else if (i == 0)
    {
        MinElement = arr[0];
    }
}
Console.WriteLine();
Console.WriteLine($"минимальный элемент: {MinElement}");
Console.WriteLine($"максимальный элемент: {MaxElement}");


