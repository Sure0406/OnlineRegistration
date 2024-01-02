using OnlineRegistrationForm.Models;

namespace OnlineRegistrationForm.Interface
{
    public interface ApplicantInterface
    {
        void CreateApplicant(Applicant applicant);
        public List<Applicant> GetApplicant();
    }
}
