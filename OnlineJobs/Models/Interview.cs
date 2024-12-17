using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineJobs.Models
{
    public class Interview
    {
        public int InterviewId { get; set; }

        [ForeignKey("Vacancy")]
        public int VacancyId { get; set; }

        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; } // Foreign Key

        [ForeignKey("Interviewer")]
        public int InterviewerId { get; set; }
        public DateTime InterviewDate { get; set; }

        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Result { get; set; }

        public Vacancy Vacancy { get; set; } // Navigation Property
        public Applicant Applicant { get; set; } // Navigation Property
        public User Interviewer { get; set; } // Navigation Property
    
    
    }
}
