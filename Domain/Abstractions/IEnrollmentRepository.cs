

using Domain.Entities;

namespace Domain.Abstractions
{
    public interface IEnrollmentRepository
    {
        Enroll EnrollStudents(Enroll enroll);
        bool CheckLectureCapacity(Subject subject);
        bool CheckWeeklyLectureHours(Student student);
        void DumpNotificationToFile(Student student, Subject subject, string message);
    }
}
