/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Write("Введите количество столбцов 1 матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк 1 матрицы: ");
int lines1 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[lines1, columns1];

Random random1 = new Random();
for (int i = 0; i < lines1; i++)
{
    for (int j = 0; j < columns1; j++)
    {
        array1[i, j] = random1.Next(10);
        Console.Write("{0,3}", array1[i, j]);
    }
    Console.WriteLine();
}
Console.Write("Введите количество столбцов 2 матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк 2 матрицы: ");
int lines2 = Convert.ToInt32(Console.ReadLine());

int[,] array2 = new int[lines2, columns2];

Random random2 = new Random();
for (int i = 0; i < lines2; i++)
{
    for (int j = 0; j < columns2; j++)
    {
        array2[i, j] = random2.Next(10);
        Console.Write("{0,3}", array2[i, j]);
    }
    Console.WriteLine();
}

int sumElementsMatrix(int[,] matrix)
{
    Console.WriteLine("_____________");
    int sumResult = 0;
    for (int line = 0; line < matrix.GetLength(0); line++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            sumResult += matrix[line, column];
        }
    }
    return sumResult;
}

int multiplyMatrices(int[,] arr1, int[,] arr2)
{
    int sumResultArray1 = sumElementsMatrix(arr1);
    int sumResultArray2 = sumElementsMatrix(arr2);
    int result = sumResultArray1 * sumResultArray2;
    return result;
}
Console.WriteLine($"произведение матриц = {multiplyMatrices(array1, array2)}");