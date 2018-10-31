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
            IEnumerable<Course> coursesList = blayer.GetAllCourses();

            //foreach (Course c in courses)
            //{
            //    Console.WriteLine(c.CourseName);
            //}

            //foreach (Student s in students)
            //{
            //    Console.WriteLine(s.StudentName);
            //}

            //foreach (Teacher t in teachers)
            //{
            //    Console.WriteLine(t.TeacherName + " ID: " + t.TeacherId);
            //}

            //foreach (var c in coursesList)
            //{
            //    Console.WriteLine(c.CourseName);
            //}

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine(
                    "\n\nMenu\n" +
                    "Teach Actions:\n" +
                    "[1] Create\n" +
                    "[2] Update\n" +
                    "[3] Delete\n" +
                    "[4] Display All" +
                    "\n\n" +
                    "Course Actions:\n" +
                    "[5] Create\n" +
                    "[6] Update\n" +
                    "[7] Delete\n" +
                    "[8] Display All\n" +
                    "[0] Exit");
                Console.Write("Choice: ");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Teacher t = AddTeacher();
                            if (t != null)
                            {
                                blayer.AddTeacher(t);
                                Console.WriteLine("Teacher added!");
                            }
                            break;
                        case 2:
                        
                            break;
                        case 3:
                            break;
                        case 4:
                            teachers = blayer.GetAllTeachers();
                            foreach (var teacher in teachers)
                            {
                                Console.WriteLine(teacher.TeacherName + " ID: " + teacher.TeacherId);
                            }
                            break;
                        case 5:
                            Course c = AddCourse();
                            if (c != null)
                            {
                                blayer.AddCourse(c);
                                Console.WriteLine("Course Added!");
                            }
                            break;
                        case 6:
                            break;
                        case 7:
                            if (RemoveCourse(blayer))
                                Console.WriteLine("Course was removed!");
                            break;
                        case 8:
                            coursesList = blayer.GetAllCourses();
                            foreach (var course in coursesList)
                            {
                                Console.WriteLine(course.CourseName);
                            }
                            break;
                        case 0:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input type.\nPress any key to continue...");
                    Console.ReadKey();
                }
            }  
            
            
        }

        public static Course AddCourse()
        {
            Course t;
            try
            {
                Console.Write("\nEnter a course name: ");
                string name = Console.ReadLine();
                //Console.Write("\nEnter course location: ");
                //string location = Console.ReadLine();
                t = new Course
                {
                    CourseName = name,
                };
                return t;
            } catch (Exception)
            {

            }
            return null;
        }

        public static bool RemoveCourse(IBusinessLayer DataAccess)
        {
            IEnumerable<Course> courseList = DataAccess.GetAllCourses();
            foreach (Course course in courseList)
            {
                Console.WriteLine(course.CourseId + " " + course.CourseName);
            }

            return false;
        }

        public static Teacher AddTeacher()
        {
            try
            {
                Console.Write("\nEnter a teacher name: ");
                string name = Console.ReadLine();
                return new Teacher {
                    TeacherName = name,
                };
            }
            catch (Exception)
            {

            }
            return null;
        }

        public static bool RemoveTeacher(IBusinessLayer DataAccess)
        {
            return false;
        }
    }

       
    
}
