using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EFCoreTutorials
{

    namespace EFCoreTutorials
    {
        class Program
        {
            private static void Main(string[] args)
            {
                var context = new SchoolContext();
                var studentsWithSameName = context.Students
                                                  .Where(s => s.FirstName == GetName())
                                                  .ToList();
            }

            public static string GetName()
            {
                return "Bill";
            }
        }
    }

    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Database=SchoolDB;Trusted_Connection=True;");
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

