﻿/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
(на вход именно поступает позиция элемента, можете разбить на две переменные или прописать в 
одну строку и конвертировать в два числа, комментарии в конце семинара по этой задаче)

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
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

Console.WriteLine("Введите индекс колонки");
int indexColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс строки");
int indexLine = Convert.ToInt32(Console.ReadLine());

if (indexColumn >= columns | indexLine >= lines)
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"Искомый элемент на указанной позиции {array[indexLine, indexColumn]}");
}