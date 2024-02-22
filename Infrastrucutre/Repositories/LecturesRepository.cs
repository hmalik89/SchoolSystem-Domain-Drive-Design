using Domain.Abstractions;
using Domain.Entities;

namespace Infrastrucutre.Repositories
{
    public class LecturesRepository : ILecturesRepository
    {
        public Lecture CreateLectureForSubject(int subjectId, Lecture lecture)
        {
            throw new NotImplementedException();
        }

        public Lecture GetLectureForSubject(int subjectId, int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lecture> GetLecturesForSubject(int subjectId)
        {
            throw new NotImplementedException();
        }
    }
}
