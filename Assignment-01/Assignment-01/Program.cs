using System;
class Program
{
    static void Main()
    {
        int[,,] matrix = new int[3, 3, 3];
        int diagonalSum = 0;
        // Input values into the 3D matrix
        Console.WriteLine("Enter the values for the 3x3x3 matrix:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write($"matrix[{i},{j},{k}]: ");
                    matrix[i, j, k] = int.Parse(Console.ReadLine());

                    // Check if the current position is on the primary diagonal
                    if (i == j && j == k)
                    {
                        diagonalSum += matrix[i, j, k];
                    }
                }
            }
        }
        // Display the matrix in a structured format
        Console.WriteLine("\nThe 3x3x3 matrix is:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Layer {i + 1}:");
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(matrix[i, j, k] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Output the sum of the diagonal
        Console.WriteLine($"The sum of the primary diagonal is: {diagonalSum}");
    }
}