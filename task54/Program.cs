/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[lines, columns];

Random random = new Random();
for (int i = 0; i < lines; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arr[i, j] = random.Next(10);
        Console.Write("{0,3}", arr[i, j]);
    }
    Console.WriteLine();
}

int[,] sortLine(int[,] array, int indexLine)
{
    int currentValue = array[indexLine, 0];
    for (int i = 0; i < array.GetLength(1) - 1; i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (j <= i)
            {
                continue;
            }

            if (array[indexLine, i] < array[indexLine, j])
            {
                currentValue = array[indexLine, i];
                array[indexLine, i] = array[indexLine, j];
                array[indexLine, j] = currentValue;
                currentValue = array[indexLine, i];
            }
        }
    }
    return array;
}

for (int line = 0; line < arr.GetLength(0); line++)
{
    sortLine(arr, line);
}
Console.WriteLine();

for (int l = 0; l < arr.GetLength(0); l++)
{
    for (int c = 0; c < arr.GetLength(1); c++)
    {
        Console.Write("{0,3}", arr[l, c]);
    }
    Console.WriteLine();
}