using Microsoft.EntityFrameworkCore;
using StudDB.models;

namespace StudDB.entities
{
    public class StudentContext : DbContext
    {
        public StudentContext( DbContextOptions options) : base(options)
        {
        }

        public DbSet<students> students { get; set; }

        public DbSet<StudentMarks> studentMarks { get; set; }

        public DbSet<StudentFee> studentFee { get; set; }
    }
}