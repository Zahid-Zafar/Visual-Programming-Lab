using System;

class Program

{

    static void Main()

    {

        Console.Write("Enter a number: ");

        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)

        {

            Console.WriteLine($"{num} is Even.");

        }

        else

        {

            Console.WriteLine($"{num} is Odd.");

        }

    }

}