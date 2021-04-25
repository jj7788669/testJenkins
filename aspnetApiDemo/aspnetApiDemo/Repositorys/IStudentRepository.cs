using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetApiDemo.Models;

namespace aspnetApiDemo.Repositorys
{
    public interface IStudentRepository
    {
         Task<IEnumerable<Student>> GetStudents();
    }
}
