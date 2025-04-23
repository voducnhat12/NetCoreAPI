using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
namespace MvcMovie.Data
{
    using Microsoft.EntityFrameworkCore;
    using MvcMovie.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

     public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //Ánh xạ class Student vào trong csdl => tạo ra bảng Students
         public DbSet<Student> Students { get; set; }
        public DbSet<Person> Person { get; set; } = default!;

         public DbSet<Employee> Employee { get; set; } = default!;

          
    }
}