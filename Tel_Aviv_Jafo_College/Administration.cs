using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic_College_Tel_Aviv_Jafo
{
    public class Administration
    {
        public List<Course> Courses;
        public List<Student> Students;
        public List<Professor> Professors;

        public void AssignStudentToCourse(Student student, Course course)
        {
            course.AddStudent(student);  // Exposing course logic directly, violating abstraction
        }

        public void UpdateStudentGrade(Student student, Course course, int newGrade)
        {
            //Logics........
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }

}
