/*
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] a = new double[line, column];

Random random = new Random();
for (int i = 0; i < line; i++)
{
    for (int j = 0; j < column; j++)
    {
        a[i, j] = random.NextDouble() * 100;
        Console.Write("{0,6:F1}", a[i, j]);
    }
    Console.WriteLine();
}