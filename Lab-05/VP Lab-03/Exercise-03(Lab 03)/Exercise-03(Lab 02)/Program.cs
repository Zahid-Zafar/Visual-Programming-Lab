using System;

class Program

{

    static void Main()

    {

        Console.Write("Enter temperature in Fahrenheit: ");

        double fahrenheit = double.Parse(Console.ReadLine());

        double centigrade = (fahrenheit - 32) *5 / 9;

        Console.WriteLine($"Temperature in Centigrade: {centigrade}");

    }

}