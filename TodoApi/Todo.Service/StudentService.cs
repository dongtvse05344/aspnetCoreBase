using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TodoApi.Data.Infrastructure;
using TodoApi.Data.Repositories;
using TodoApi.Model;

namespace Todo.Service
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        IEnumerable<Student> GetStudents(Expression<Func<Student, bool>> where);
        Student GetStudent(Guid id);
        void Create(Student student);
        void Update(Student student);
        void Delete(Student student);
        void SaveChange();
    }
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public StudentService(IStudentRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Create(Student student)
        {
            _repository.Add(student);
        }

        public void Delete(Student student)
        {
            _repository.Delete(student);
        }

        public Student GetStudent(Guid id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Student> GetStudents(Expression<Func<Student, bool>> where)
        {
            return _repository.GetMany(where);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(Student student)
        {
            _repository.Update(student);
        }
    }
}
