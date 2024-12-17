using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineJobs.Data;
using OnlineJobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJobs.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reports/VacancyReport
        public async Task<IActionResult> VacancyReport()
        {
            // Fetch data for the report (example: number of open/closed vacancies, vacancies by department)
            var reportData = new VacancyReportViewModel
            {
                TotalVacancies = await _context.Vacancies.CountAsync(),
                OpenVacancies = await _context.Vacancies.CountAsync(v => v.Status == "Open"),
                ClosedVacancies = await _context.Vacancies.CountAsync(v => v.Status == "Closed"),
                VacanciesByDepartment = await _context.Vacancies
    .GroupBy(v => v.Department)
    .Select(g => new VacancyDepartmentCount { Department = g.Key, Count = g.Count() })
    .ToListAsync()
            };

            return View(reportData);
        }

        // GET: Reports/ApplicantReport
        public async Task<IActionResult> ApplicantReport()
        {
            // Fetch data for the report (example: number of applicants, applicants by status)
            var reportData = new ApplicantReportViewModel
            {
                TotalApplicants = await _context.Applicants.CountAsync(),
                AppliedToday = await _context.Applicants.CountAsync(a => a.AppliedAt.Date == DateTime.Today),
                ApplicantsByRole = await _context.Applicants
                 .GroupBy(a => a.Role) // Group by Role
                 .Select(g => new ApplicantRoleCount { Role = g.Key, Count = g.Count() })
                 .ToListAsync()
            };

            return View(reportData);
        }

        // GET: Reports/InterviewReport
        public async Task<IActionResult> InterviewReport()
        {
            // Fetch data for the report (example: number of scheduled/completed interviews)
            var reportData = new InterviewReportViewModel
            {
                TotalInterviews = await _context.Interviews.CountAsync(),
                ScheduledInterviews = await _context.Interviews.CountAsync(i => i.Date > DateTime.Now),
                CompletedInterviews = await _context.Interviews.CountAsync(i => i.Result == "Completed")
            };

            return View(reportData);
        }

        // View Models for Reports
        public class VacancyReportViewModel
        {
            public int TotalVacancies { get; set; }
            public int OpenVacancies { get; set; }
            public int ClosedVacancies { get; set; }
            public List<VacancyDepartmentCount> VacanciesByDepartment { get; set; }
        }

        public class VacancyDepartmentCount
        {
            public string Department { get; set; }
            public int Count { get; set; }
        }

        public class ApplicantReportViewModel
        {
            public int TotalApplicants { get; set; }
            public int AppliedToday { get; set; }
            public List<ApplicantRoleCount> ApplicantsByRole { get; set; }
        }

        public class ApplicantRoleCount
        {
            public string Role { get; set; }
            public int Count { get; set; }
        }

        public class ApplicantStatusCount
        {
            public string Status { get; set; }
            public int Count { get; set; }
        }

        public class InterviewReportViewModel
        {
            public int TotalInterviews { get; set; }
            public int ScheduledInterviews { get; set; }
            public int CompletedInterviews { get; set; }
        }
    }
}
