using System;

namespace Ex
{
    class MatrixMultiplication
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[3, 3];
            int[,] matrixB = new int[3, 3];
            int[,] resultMatrix = new int[3, 3];

            Console.WriteLine("Enter elements of Matrix A (3x3):");
            InputMatrix(matrixA);

            Console.WriteLine("Enter elements of Matrix B (3x3):");
            InputMatrix(matrixB);

            resultMatrix = MultiplyMatrices(matrixA, matrixB);

            Console.WriteLine("Resultant Matrix (A x B):");
            DisplayMatrix(resultMatrix);
        }

        static void InputMatrix(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
        {
            int[,] result = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = 0; // Initialize result element
                    for (int k = 0; k < 3; k++)
                    {
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            return result;
        }

        static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
