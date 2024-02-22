namespace Domain.Entities
{
    // Lecture
    public class Lecture
    {
        public int LectureId { get; set; }
        public int SubjectId { get; set; }
        public int LectureTheatreId { get; set; }
        public string DayOfWeek { get; set; }
        public string StartTime { get; set; }
        public int DurationInMinutes { get; set; }
        public Subject Subject { get; set; }
        public LectureTheatre LectureTheatre { get; set; }
    }
}
