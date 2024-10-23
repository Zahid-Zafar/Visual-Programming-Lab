using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Decimal to Binary and Binary to Decimal Converter");
        Console.WriteLine("1. Convert Decimal to Binary");
        Console.WriteLine("2. Convert Binary to Decimal");
        Console.Write("Choose an option (1 or 2): ");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("Enter a decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            string binaryNumber = DecimalToBinary(decimalNumber);
            Console.WriteLine($"Binary representation: {binaryNumber}");
        }
        else if (choice == "2")
        {
            Console.Write("Enter a binary number: ");
            string binaryInput = Console.ReadLine();
            int decimalNumber = BinaryToDecimal(binaryInput);
            Console.WriteLine($"Decimal representation: {decimalNumber}");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select 1 or 2.");
        }
    }

    static string DecimalToBinary(int decimalNumber)
    {
        return Convert.ToString(decimalNumber, 2);
    }

    static int BinaryToDecimal(string binaryInput)
    {
        return Convert.ToInt32(binaryInput, 2);
    }
}
