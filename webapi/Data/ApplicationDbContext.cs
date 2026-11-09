using webapi.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace webapi.Data
{
    public class ApplicationDbContext : DbContext
    {

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }

    
}
