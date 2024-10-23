using System;

class Program

{
    static void Main()

    {

        Console.Write("Enter first number: ");

        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");

        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");

        int num3 = int.Parse(Console.ReadLine());

        int smallest = num1;

        if (num2 < smallest)

        smallest = num2;

        if (num3 < smallest)

        smallest = num3;

        Console.WriteLine($"Smallest number is: {smallest}");

    }

}