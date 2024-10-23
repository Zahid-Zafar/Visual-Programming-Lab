using System;

class Program

{
    static void Main()

    {

        int totalMarks = 0;

        int numOfStudents = 0;

        while (true)

        {
            Console.Write("Enter student marks (or 1 to stop):" );
        

        int marks = int.Parse(Console.ReadLine());

            if (marks == -1)

                break;

            totalMarks += marks;

            numOfStudents++;
        }

        if (numOfStudents > 0)

        {
            double average = totalMarks / (double)numOfStudents;

            Console.WriteLine($"Average marks of the class: { average}"); }
           





else

            { Console.WriteLine("No marks entered."); }


        }
    }