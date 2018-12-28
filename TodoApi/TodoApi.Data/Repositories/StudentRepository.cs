using System;
using System.Collections.Generic;
using System.Text;
using TodoApi.Data.Infrastructure;
using TodoApi.Model;

namespace TodoApi.Data.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
    }
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
