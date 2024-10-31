using Microsoft.EntityFrameworkCore;
using StudentRecordManagementApi.Models;

namespace StudentRecordManagementApi.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}

