//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число.\nВыхода из программы команда end. ");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("end"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }        