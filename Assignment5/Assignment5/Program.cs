using BusinessLayer;
using BusinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBusinessLayer blayer = new BusinessLayer.BusinessLayer();
            IEnumerable<Student> students = blayer.GetAllStudents();
            IEnumerable<Teacher> teachers = blayer.GetAllTeachers();
            IEnumerable<Course> courses = blayer.GetTeacherCourses(5);

            foreach(Course c in courses)
            {
                Console.WriteLine(c.CourseName);
            }

            foreach(Student s in students)
            {
                Console.WriteLine(s.StudentName);
            }

            foreach(Teacher t in teachers)
            {
                Console.WriteLine(t.TeacherName + " ID: " + t.TeacherId);
            }
            Console.ReadKey();
            
        }
                  
                
            
     }

       
    
}
