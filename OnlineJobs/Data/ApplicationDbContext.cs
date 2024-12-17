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
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Department> Departments { get; set; }
            


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Interview -> Vacancy relationship
            modelBuilder.Entity<Interview>()
                .HasOne(i => i.Vacancy)
                .WithMany(v => v.Interviews)
                .HasForeignKey(i => i.VacancyId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            // Configure Interview -> Applicant relationship
            modelBuilder.Entity<Interview>()
                .HasOne(i => i.Applicant)
                .WithMany(a => a.Interviews)
                .HasForeignKey(i => i.ApplicantId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            // Configure Interview -> User (Interviewer) relationship
            modelBuilder.Entity<Interview>()
                .HasOne(i => i.Interviewer)
                .WithMany()
                .HasForeignKey(i => i.InterviewerId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete
        }
    }
}
