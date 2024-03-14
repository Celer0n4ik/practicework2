using System;

class Student
{
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string GroupNumber { get; set; }
    public double[] Grades { get; set; }

    public Student(string lastName, DateTime dateOfBirth, string groupNumber, double[] grades)
    {
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        GroupNumber = groupNumber;
        Grades = grades;
    }

    public void ChangeLastName(string newLastName)
    {
        LastName = newLastName;
    }

    public void ChangeDateOfBirth(DateTime newDateOfBirth)
    {
        DateOfBirth = newDateOfBirth;
    }

    public void ChangeGroupNumber(string newGroupNumber)
    {
        GroupNumber = newGroupNumber;
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine("Student Information:");
        Console.WriteLine("Last Name: " + LastName);
        Console.WriteLine("Date of Birth: " + DateOfBirth.ToShortDateString());
        Console.WriteLine("Group Number: " + GroupNumber);
        Console.WriteLine("Grades: " + string.Join(", ", Grades));
    }
}

class Program
{
    static void Main(string[] args)
    {
        double[] grades = { 9.5, 8.7, 9.0, 7.8, 9.2 };

        Student student = new Student("Ivanov", new DateTime(2000, 5, 15), "Group A", grades);

        Console.WriteLine("Before changes:");
        student.PrintStudentInfo();

        Console.WriteLine("Enter new Last Name:");
        string newLastName = Console.ReadLine();
        student.ChangeLastName(newLastName);

        Console.WriteLine("Enter new Date of Birth (yyyy-MM-dd):");
        DateTime newDateOfBirth = DateTime.Parse(Console.ReadLine());
        student.ChangeDateOfBirth(newDateOfBirth);

        Console.WriteLine("Enter new Group Number:");
        string newGroupNumber = Console.ReadLine();
        student.ChangeGroupNumber(newGroupNumber);

        Console.WriteLine("After changes:");
        student.PrintStudentInfo();

        Console.ReadKey();
    }
}