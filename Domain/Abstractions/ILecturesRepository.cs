using Domain.Entities;

namespace Domain.Abstractions
{
    public interface ILecturesRepository
    {
        IEnumerable<Lecture> GetLecturesForSubject(int subjectId);
        Lecture GetLectureForSubject(int subjectId, int id);
        Lecture CreateLectureForSubject(int subjectId, Lecture lecture);
    }
}
