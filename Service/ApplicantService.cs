using OnlineRegistrationForm.Data;
using OnlineRegistrationForm.Interface;
using OnlineRegistrationForm.Models;

namespace OnlineRegistrationForm.Service
{
    public class ApplicantService : ApplicantInterface
    {
        private readonly ApplicantDbContext _applicantDbContext;
        public ApplicantService(ApplicantDbContext applicantDbContext)
        {
            _applicantDbContext = applicantDbContext;
        }
        public void CreateApplicant(Applicant applicant)
        {
            _applicantDbContext.Add(applicant);
            _applicantDbContext.SaveChanges();
        }

        public List<Applicant> GetApplicant()
        {
          List<Applicant> applicant = _applicantDbContext.Applicants.ToList();
            return applicant;
        }
    }
}
