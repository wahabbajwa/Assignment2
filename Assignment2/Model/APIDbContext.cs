using Microsoft.EntityFrameworkCore;

namespace Assignment2.Model
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions option) : base(option)
        { }

        public DbSet<Student> StudentsRecord { get; set; }
    }

}
