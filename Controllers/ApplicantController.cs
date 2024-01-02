using Microsoft.AspNetCore.Mvc;
using OnlineRegistrationForm.Data;
using OnlineRegistrationForm.Interface;
using OnlineRegistrationForm.Models;
using OnlineRegistrationForm.Service;
using System.Diagnostics;

namespace OnlineRegistrationForm.Controllers
{
    public class ApplicantController : Controller
    {
        private readonly ApplicantDbContext _applicantDbContext;
        private readonly ApplicantInterface _applicantInterface;

        public ApplicantController(ApplicantDbContext applicantDbContext, ApplicantInterface applicantInterface)
        {
            _applicantDbContext = applicantDbContext;
            _applicantInterface = applicantInterface;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(Applicant applicant)
        {
            var uploadedFile = Request.Form.Files[0];
            var imagePath = "/uploads/" + uploadedFile.FileName;
            applicant.ImagePath = imagePath;
            _applicantInterface.CreateApplicant(applicant);
            return Index();
        }

        public IActionResult GetApplicant()
        {
            List<Applicant> applicant =_applicantInterface.GetApplicant();
            return View(applicant);
        }
    }
}