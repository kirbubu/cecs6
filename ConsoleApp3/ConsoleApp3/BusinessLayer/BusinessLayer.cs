using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.DataAccessLayer;

namespace ConsoleApp3.BusinessLayer
{
    public interface IBusinessLayer
    {
        IList<Standard> GetAllStandards();
        Standard GetStandardByID(int id);
        void AddStandard(Standard s);
        void UpdateStandard(Standard s);
        void RemoveStandard(Standard s);
        IList<Student> GetAllStudents();
        Student GetStudentByID(int id);
        void AddStudent(Student st);
        void UpdateStudent(Student st);
        void RemoveStudent(Student st);
    }
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IStandardRepository _standardRepository;
        private readonly IStudentRepository _studentRepository;

        public BusinessLayer()
        {
            _standardRepository = new StandardRepository();
            _studentRepository = new StudentRepository();
        }

        public void AddStandard(Standard standard)
        {
            _standardRepository.Insert(standard);
        }

        public void AddStudent(Student student)
        {
            _studentRepository.Insert(student);
        }

        public IList<Standard> GetAllStandards()
        {
            return (IList<Standard>)_standardRepository.GetAll();
        }

        public IList<Student> GetAllStudents()
        {
            return (IList<Student>)_studentRepository.GetAll();    
        }

        public Standard GetStandardByID(int id)
        {
            return _standardRepository.GetSingle(
                s => s.StandardId.Equals(id), s => s.Students);
        }

        public Student GetStudentByID(int id)
        {
            //dunno what to do here
            return _studentRepository.GetSingle(
                s => s.StudentID.Equals(id), s =>);
        }

        public void RemoveStandard(Standard s)
        {
            _standardRepository.Delete(s);
        }

        public void RemoveStudent(Student st)
        {
            _studentRepository.Delete(st);
        }

        public void UpdateStandard(Standard s)
        {
            _standardRepository.Update(s);
        }

        public void UpdateStudent(Student st)
        {
            _studentRepository.Update(st);
        }


        //Implement other methods

    }
}
