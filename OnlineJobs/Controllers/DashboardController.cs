using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineJobs.Data;
using OnlineJobs.Models;

public class DashboardController : Controller
{
    private readonly ApplicationDbContext _dbContext;

    public DashboardController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IActionResult> ViewDashboard()
    {
        var dashboardData = new DashboardViewModel
        {
            TotalApplicants = await _dbContext.Applicants.CountAsync(),
            OpenVacancies = await _dbContext.Vacancies.CountAsync(v => v.Status == "Open"),
            CompletedInterviews = await _dbContext.Interviews.CountAsync(i => i.Result == "Completed"), // Filter by Result
            ApplicationsToday = await _dbContext.Applicants.CountAsync(a => a.AppliedAt.Date == DateTime.Today),

            RecentApplicants = await _dbContext.Applicants
                                               .OrderByDescending(a => a.AppliedAt)
                                               .Take(5)
                                               .ToListAsync(),
            UpcomingInterviews = await _dbContext.Interviews
                                               .Where(i => i.Date > DateTime.Now)
                                               .Take(5)
                                               .ToListAsync(),
            RecentVacancies = await _dbContext.Vacancies
                                               .OrderByDescending(v => v.CreatedAt)
                                               .Take(5)
                                               .ToListAsync(),

            IsHR = User.IsInRole("HR"),
            IsInterviewer = User.IsInRole("Interviewer"),
        };

        return View(dashboardData);
    }
}