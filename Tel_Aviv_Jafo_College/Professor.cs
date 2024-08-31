using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic_College_Tel_Aviv_Jafo
{
    public class Professor
    {
        public string Name { get; set; }  // Should be private set
        List<Course> CoursesITeach;
        public Administration admin;

        public Professor(string name)
        {
            Name = name;
        }

        // Exposing a method that should be private, as it's internal logic
        public void AssignGrade(Student student, int grade)
        {
            // Logic to assign grade
        }
    }

}
