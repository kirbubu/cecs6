﻿using DataAccessLayer;
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
    }
}