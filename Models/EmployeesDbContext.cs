using Microsoft.EntityFrameworkCore;

namespace Employees.Models
{
    public class EmployeesDbContext : DbContext
    {
        public EmployeesDbContext(DbContextOptions<EmployeesDbContext> options) : base(options)
        { 

        }
        public DbSet<Oddeli> Oddeli { get; set; }
        public DbSet<Vraboteni> Vraboteni { get; set;}
    }
}
