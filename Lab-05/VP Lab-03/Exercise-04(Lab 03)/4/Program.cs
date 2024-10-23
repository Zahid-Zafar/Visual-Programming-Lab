using System;

class Program

{

    static void Main()

    {

        Console.Write("Enter a number to calculate factorial:");
        

        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"Factorial of {num} is: {Factorial(num)}");

    }

    static int Factorial(int num)

    {

        int fact = 1;

for (int i = 1; i <= num; i++)

        {

            fact *= i;

        }

        return fact;

    }

}