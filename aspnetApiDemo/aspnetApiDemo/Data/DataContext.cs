using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetApiDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetApiDemo.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        
    }
}
