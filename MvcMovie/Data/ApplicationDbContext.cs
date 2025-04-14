using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Person> Person { get; set; } = default!;
         public DbSet<Employee> Employee { get; set; } = default!;
      //  public DbSet<MvcMovie.Models.Employee> Employee { get; set; } = default!;
    }
}
