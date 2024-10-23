using System;

namespace Marks
{
    class Program
    {
        static void Main()
        {
            int[,] testMarks = {
                { 85, 90, 78, 92, 88, 76, 95, 89, 84, 91 },
                { 82, 85, 86, 87, 98, 79, 83, 86, 88, 92 },
                { 98, 93, 87, 85, 88, 91, 84, 89, 90, 92 },
                { 78, 75, 80, 82, 88, 76, 84, 90, 85, 81 },
                { 92, 95, 91, 89, 90, 94, 88, 87, 93, 90 }
            };

            Console.WriteLine("Test Marks for 5 Courses (Rows represent courses and Columns represent students): ");
            for (int course = 0; course < 5; course++)
            {
                Console.Write($"Course {course + 1}: ");
                for (int student = 0; student < 10; student++)
                {
                    Console.Write(testMarks[course, student] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Average Marks for each student: ");
            for (int student = 0; student < 10; student++)
            {
                int total = 0;
                for (int course = 0; course < 5; course++)
                {
                    total += testMarks[course, student];
                }
                double average = total / 5.0;
                Console.Write($"{average:F2}  "); // Format average to 2 decimal places
            }
            Console.WriteLine();
        }
    }
}
