/*namespace OnlineJobs.Models
{
    public class Interview
    {
        public int InterviewId { get; set; }
        public int VacancyId { get; set; }
        public int ApplicantId { get; set; }
        public int InterviewerId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Result { get; set; }

        public Vacancy Vacancy { get; set; } // Navigation Property
        public Applicant Applicant { get; set; } // Navigation Property
        public User Interviewer { get; set; } // Navigation Property

        // Calculated Property for Combined Date and Time
        public DateTime InterviewDate
        {
            get { return Date.Add(Time); }
            set
            {
                Date = value.Date;
                Time = value.TimeOfDay;
            }
        }
    }
}
*/