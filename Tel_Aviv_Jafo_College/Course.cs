using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic_College_Tel_Aviv_Jafo
{
    public class Course
    {
        public string CourseName { get; set; }
        public List<Student> Students;  // Should be private

        public Course(string courseName)
        {
            CourseName = courseName;
            Students = new List<Student>();
        }

        // Method to directly add a student, but exposes too much internal logic
        public void AddStudent(Student student)
        {
            Students.Add(student);  // Violates abstraction by exposing internal workings directly
        }

        // No abstraction for handling course logic, everything is exposed
    }

}
