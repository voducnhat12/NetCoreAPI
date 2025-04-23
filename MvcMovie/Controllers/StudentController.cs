using MvcMovie.Data;
using MvcMovie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Controllers
{
    public class StudentController : Controller
    {
        //khai bao dbcontext
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            //lay danh sach cac ban ghi trong bang Students
            var students = await _context.Students.ToListAsync();
            //tra ve view kem theo la du lieu students
            return View(students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student std)
        {
            await _context.AddAsync(std);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}