using System;

namespace EFCoreTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }

}

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
}