//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет


    int n = Convert.ToInt32(Console.ReadLine());
      if(n>99)
      {Console.WriteLine(n>99 ? n.ToString()[2]:
      Console.ReadKey(true));}

      else
      {
        Console.WriteLine("третьей цифры нет");
      }
