using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic_College_Tel_Aviv_Jafo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Accessing Singleton instance of UniversityDatabase
            UniversityDatabase database = UniversityDatabase.Instance;

            // Creating Courses
            Course course1 = new Course("Computer Science 101");
            Course course2 = new Course("Mathematics 101");

            // Adding Courses to UniversityDatabase
            database.AddCourse(course1);
            database.AddCourse(course2);

            // Creating Students
            Student student1 = new Student("Alice", 12345);
            Student student2 = new Student("Bob", 67890);

            // Adding Students to UniversityDatabase
            database.AddStudent(student1);
            database.AddStudent(student2);

            // Accessing Singleton instance of UniversityAdmin
            Administration admin = Administration.Instance;

            // Assigning Students to Courses
            admin.AssignStudentToCourse(student1, course1);
            admin.AssignStudentToCourse(student2, course2);

            // Printing all Courses
            admin.PrintAllCourses(database);
        }
    }

}
