using DataAccessLayer;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IBusinessLayer
    {
        #region Standard
        IEnumerable<Standard> GetAllStandards();

        Standard GetStandardByID(int id);

        Standard GetStandardByName(string name);

        void AddStandard(Standard standard);

        void UpdateStandard(Standard standard);

        void RemoveStandard(Standard standard);
        #endregion

        #region Student
        IEnumerable<Student> GetAllStudents();

        Student GetStudentByID(int id);

        void AddStudent(Student st);

        void UpdateStudent(Student st);

        void RemoveStudent(Student st);
        #endregion

        #region Teacher
        IEnumerable<Teacher> GetAllTeachers();

        Teacher GetTeacherByID(int id);

        void AddTeacher(Teacher teacher);

        void UpdateTeacher(Teacher teacher);

        void UpdateTeacher(int id);

        void RemoveTeacher(Teacher teacher);

        IEnumerable<Course> GetTeacherCourses(int id);

        Teacher GetTeacherByName(string name);
        #endregion

        #region Course
        IEnumerable<Course> GetAllCourses();
        Course GetCourseByID(int id);
        void AddCourse(Course course);
        void UpdateCourse(Course course);
        void RemoveCourse(Course course);
        void RemoveCourse(int id);
        Course GetCourseByName(string name);
        #endregion
    }
}