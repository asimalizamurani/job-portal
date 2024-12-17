namespace OnlineJobs.Models
{
    public class Vacancy
    {
        public int VacancyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
        public int PositionsAvailable { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public User CreatedByUser { get; set; } // Navigation Property

        public ICollection<Interview> Interviews { get; set; } // Navigation Property

    }
}
