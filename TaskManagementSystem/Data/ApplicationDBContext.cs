using Microsoft.EntityFrameworkCore;

namespace TaskManagementSystem.Models
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options)
        {

        }
        public DbSet<Task> Tasks { get; set; }
    }
}
