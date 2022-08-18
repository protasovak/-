/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


int[] arr = new int[5];

            int SumResult = 0;
            Random rnd = new Random();
 
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0,9);
                Console.Write($"{arr[i]} ");
                if (i % 2 != 0) 
                {
                    SumResult += arr[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Сумма элементов,стоящих на нечетных позициях : {SumResult}");
