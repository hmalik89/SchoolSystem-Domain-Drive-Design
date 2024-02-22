
namespace Domain.Entities
{
    // Student
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public int weeklyHours { get; set; }
        public List<Enroll> Enrollments { get; set; }
    }
}
