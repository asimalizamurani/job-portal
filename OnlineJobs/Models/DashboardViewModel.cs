namespace OnlineJobs.Models
{
    public class DashboardViewModel
    {
        // General Metrics
        public int TotalApplicants { get; set; }
        public int OpenVacancies { get; set; }
        public int CompletedInterviews { get; set; }
        public int ApplicationsToday { get; set; }

        // Recent Activities
        public List<Applicant> RecentApplicants { get; set; }
        public List<Interview> UpcomingInterviews { get; set; }
        public List<Vacancy> RecentVacancies { get; set; }

        // Role-Specific Data (Optional)
        public bool IsHR { get; set; }
        public bool IsInterviewer { get; set; }
    }
}
