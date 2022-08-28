/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());

int[,] a = new int[lines, columns];

Random random = new Random();
for (int i = 0; i < lines; i++)
{
    for (int j = 0; j < columns; j++)
    {
        a[i, j] = random.Next(10);
        Console.Write("{0,3}", a[i, j]);
    }
    Console.WriteLine();
}

for (int col = 0; col < columns; col++){
    int sumColumn = 0;
    for (int line = 0; line < lines; line++)
    {
        sumColumn += a[line, col];

    }
  
    Console.WriteLine($"Среднее арифметическое {col}-го столбца равна {Math.Round ((double)sumColumn / lines,2)}");    

}