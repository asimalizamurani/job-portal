using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineJobs.Data;
using OnlineJobs.Models;

namespace OnlineJobs.Controllers
{
    public class InterviewController : Controller
    {

        public IActionResult ViewInterview()
        {
                return View();
            }
            /*private readonly ApplicationDbContext _context;

            public InterviewController(ApplicationDbContext context)
            {
                _context = context;
            }

            public IActionResult ViewInterview(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var interview = _context.Interviews
                    .Include(i => i.Applicant)
                    .Include(i => i.Vacancy)
                    .Include(i => i.Interviewer)
                    .FirstOrDefault(m => m.InterviewId == id);

                if (interview == null)
                {
                    return NotFound();
                }

                return View(interview);
            }*/
        }
}