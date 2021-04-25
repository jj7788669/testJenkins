using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetApiDemo.Data;
using aspnetApiDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetApiDemo.Repositorys
{
    public class StudentRepository:IStudentRepository
    {
        private readonly DataContext _context;

        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public async  Task<IEnumerable<Student>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }
    }
}
