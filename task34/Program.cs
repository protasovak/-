/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
*/

int[] arr = new int[3];

int k = 0;
Random rnd = new Random();
 
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(99,1000);
}

foreach(int element in arr)
{
    Console.Write("{0} ", element);
    if (element % 2 == 0)
    {
        k++;
    }
 }
Console.WriteLine();
Console.WriteLine("Количество четных чисел {0} ", k);
