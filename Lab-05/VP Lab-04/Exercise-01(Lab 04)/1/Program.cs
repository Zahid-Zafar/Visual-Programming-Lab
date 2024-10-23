using System;

namespace Ex
{
    class Program

    {

        static void Main(string[] args)
        {

            int[,] array ={
                {1,2,3},
                {4,5,6},
                {7,8,9}
               };

            multi_array(array);

        }
        private static void multi_array(int[,] array)
        {

            Console.WriteLine($"Element of array is:"); 
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write($"{array[i, j]} ");

                }

                Console.Write("\n");
            }
        }
    }
}