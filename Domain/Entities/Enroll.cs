
namespace Domain.Entities
{
    public class Enroll
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }

        public void checkHours()
        {
            if (Student.weeklyHours > 10)
            {
                throw new Exception("not enrolled");
            }
        }
    }
}
