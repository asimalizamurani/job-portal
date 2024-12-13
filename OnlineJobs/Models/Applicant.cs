namespace OnlineJobs.Models
{
    public class Applicant
    {
        public int ApplicantId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public int AttachedVacancyId { get; set; }
        public string ResumePath { get; set; }
        public DateTime AppliedAt { get; set; }

        public Vacancy AttachedVacancy { get; set; } // Navigation Property
    }
}
