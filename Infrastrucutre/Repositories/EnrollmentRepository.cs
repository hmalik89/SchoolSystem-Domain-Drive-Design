using Domain.Abstractions;
using Domain.Entities;

namespace Infrastrucutre.Repositories
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        public bool CheckLectureCapacity(Subject subject)
        {
            throw new NotImplementedException();
        }

        public bool CheckWeeklyLectureHours(Student student)
        {
            throw new NotImplementedException();
        }

        public void DumpNotificationToFile(Student student, Subject subject, string message)
        {
            throw new NotImplementedException();
        }

        public Enroll EnrollStudents(Enroll enroll)
        {
            var enrolledStudent = new Enroll();
            try
            {
                // Retrieve data from the DB
                var student = new Student { StudentId = 1 };  // Reterive Student;
                var subject = new Subject { SubjectId = 2 }; // Reterive Subject;

                // Check business rules
                if (CheckLectureCapacity(subject) && CheckWeeklyLectureHours(student))
                {
                    // Perform enrollment & Save chagnes in DB
                    // Send notification (for simulation, you can dump a file to disk)
                    DumpNotificationToFile(student, subject, "student x with Subject is enrolled");
                }
                else
                {
                    // Reject enrollment
                    DumpNotificationToFile(student, subject, "Enrollment rejected.");
                }

            }
            catch (Exception e) { }
            return enrolledStudent;
        }
    }
}
