using Microsoft.EntityFrameworkCore;
using OnlineRegistrationForm.Models;

namespace OnlineRegistrationForm.Data
{
    public class ApplicantDbContext:DbContext
    {
        public ApplicantDbContext(DbContextOptions<ApplicantDbContext> options): base(options)
        {
            
        }
        public DbSet<Applicant> Applicants { get; set; }
    }
}
