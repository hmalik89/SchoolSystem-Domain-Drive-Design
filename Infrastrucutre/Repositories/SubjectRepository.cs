using Domain.Abstractions;
using Domain.Entities;

namespace Infrastrucutre.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        public Subject CreateSubject(Subject subject)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subject> GetAllSubjects()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudentsForSubject(int subjectId)
        {
            throw new NotImplementedException();
        }

        public Subject GetSubjectById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
