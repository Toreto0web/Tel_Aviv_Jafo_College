using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academic_College_Tel_Aviv_Jafo
{
    public class Student
    {
        public string Name { get; }
        private int ID { get; set; }
        List<Course> My_Courses;
        public Administration admin;

        public Student(string name, int id)
        {
            Name = name;
            ID = id;
        }

        // Public method to set ID, which should not be allowed publicly
        public void SetID(int id)
        {
            ID = id;  // Violates encapsulation by allowing ID to be changed publicly
        }
    }

}
