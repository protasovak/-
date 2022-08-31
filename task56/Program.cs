/*
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
элементов: 1 строка
*/

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[lines, columns];

Random random = new Random();
for (int i = 0; i < lines; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = random.Next(10);
        Console.Write("{0,3}", array[i, j]);
    }
    Console.WriteLine();
}

int minLineNumber = 0;
int minSumLine = SumLineElements(array, 0);
for (int linecount = 1;  linecount < array.GetLength(0); linecount++)
{
  int currentSumLine = SumLineElements(array, linecount);
  if (minSumLine > currentSumLine)
  {
    minSumLine = currentSumLine;
    minLineNumber = linecount;
  }
}

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

Console.WriteLine($"\n{minLineNumber+1}-я  строкa с наименьшей суммой элементов равной {minSumLine}");


