using Microsoft.EntityFrameworkCore;
using OnlineJobs.Models;

namespace OnlineJobs.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<Applicant> Applicants { get; set; }

        public DbSet<Department> Departments { get; set; }

    }
}
