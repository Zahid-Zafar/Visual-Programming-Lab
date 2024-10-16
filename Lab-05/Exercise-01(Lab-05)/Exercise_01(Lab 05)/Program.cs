using System;

public enum Department
{
    None,
    ComputerScience,
    ElectricalEngineering,
    MechanicalEngineering
}

public class Person
{
    // Instance variable
    private string name;

    // No-argument constructor
    public Person()
    {
        name = null; // Default value
    }

    // Multi-argument constructor
    public Person(string name)
    {
        this.name = name;
    }

    // Property for name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

public class Student : Person
{
    // Instance variables
    private string regNo;
    private int age;
    private Department program;

    // No-argument constructor
    public Student() : base()
    {
        regNo = null; // Default value
        age = 0; // Default value
        program = Department.None; // Default value
    }

    // Multi-argument constructor
    public Student(string name, string regNo, int age, Department program) : base(name)
    {
        this.regNo = regNo;
        this.age = age;
        this.program = program;
    }

    // Property for regNo
    public string RegNo
    {
        get { return regNo; }
        set { regNo = value; }
    }

    // Property for age
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Property for program
    public Department Program
    {
        get { return program; }
        set { program = value; }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create a student object
        Student john = new Student("Bilal Talib", "233546", 20, Department.ComputerScience);

        // Print student information
        Console.WriteLine("Name: " + john.Name);
        Console.WriteLine("Registration Number: " + john.RegNo);
        Console.WriteLine("Age: " + john.Age);
        Console.WriteLine("Program: " + john.Program);
    }
}
