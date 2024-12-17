using Microsoft.AspNetCore.Mvc;
using OnlineJobs.Models;

namespace OnlineJobs.Controllers
{
    public class ApplicantController : Controller
    {
        public IActionResult ViewApplicant()
        {
            // Simulate fetching data from a database
            var applicants = new List<Applicant>
    {
        new Applicant { ApplicantId = 1, Name = "John Doe", Email = "john.doe@example.com", Role = "Developer", AttachedVacancyId = 101, ResumePath = "/resumes/johndoe.pdf", AppliedAt = DateTime.Now.AddDays(-3) },
        new Applicant { ApplicantId = 2, Name = "Jane Smith", Email = "jane.smith@example.com", Role = "Designer", AttachedVacancyId = 102, ResumePath = "/resumes/janesmith.pdf", AppliedAt = DateTime.Now.AddDays(-7) }
    };

            return View(applicants);
        }
    }
}
