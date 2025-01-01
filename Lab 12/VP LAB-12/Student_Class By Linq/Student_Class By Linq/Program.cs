using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Class_By_Linq
{
    public class StudentClass
    {
        static void Main(string[] args)
        {
            // Example usage: Search for First Year students with an exam score of at least 90
            var results = SearchStudents(GradeLevel.FirstYear, 90);
            foreach (var student in results)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} (ID: {student.ID}) - Average Score: {student.ExamScores.Average()}");
            }

            Console.ReadLine();

        }

        protected enum GradeLevel { FirstYear=1,SecondYear,ThirdYear,FourthYear };

        protected class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public int ID { get; set; }
            public GradeLevel Year;

            public List<int> ExamScores;
        }

        protected static List<Student> students = new List<Student>
        {
            new Student{FirstName="Jerry",LastName="Admas",ID=120,Year=GradeLevel.SecondYear,ExamScores=new List<int>{99,82,81,89} },
            new Student{FirstName="Ali",LastName="Bilal",ID=117,Year=GradeLevel.FirstYear,ExamScores=new List<int>{88,78,76,87} },
            new Student{FirstName="Hasnain",LastName="Naseer",ID=116,Year=GradeLevel.ThirdYear,ExamScores=new List<int>{84,77,71,86} },
            new Student{FirstName="Maaz",LastName="Raheem",ID=115,Year=GradeLevel.FirstYear,ExamScores=new List<int>{90,80,71,85} },
            new Student{FirstName="Sarib",LastName="Syed",ID=114,Year=GradeLevel.SecondYear,ExamScores=new List<int>{92,72,75,81} }
        };

        protected static int GetPercentile(Student s)
        {
            double avg =s.ExamScores.Average();
            return avg > 0 ? (int)avg / 10 : 0;
        }

        protected static List<Student> SearchStudents(GradeLevel gradeLevel, int minScore)
        {
            var query = from student in students
                        where student.Year == gradeLevel
                        where student.ExamScores.Any(score => score >= minScore)
                        select student;

            return query.ToList();
        }


    }
}
