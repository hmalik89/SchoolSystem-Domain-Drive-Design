
namespace Domain.Entities
{
    // Subject
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public List<Enroll> Enrollments { get; set; }
        public List<Lecture> Lectures { get; set; }
    }
}
