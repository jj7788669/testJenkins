using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetApiDemo.Models;
using aspnetApiDemo.Repositorys;

namespace aspnetApiDemo.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        [Route("test")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Student> students = await _studentRepository.GetStudents();
            ViewBag.PageTitle = "students Details";
            ViewBag.Students = students;
            return View(students);
        }
    }
}
