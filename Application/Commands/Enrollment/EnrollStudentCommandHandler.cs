using Domain.Abstractions;
using Domain.Entities;
using MediatR;

namespace Application.Commands.Enrollment
{
    internal sealed class EnrollStudentCommandHandler : IRequestHandler<EnrollStudentCommad, Enroll>
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly IStudentsRepository _studentsRepository;
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollStudentCommandHandler(ISubjectRepository subjectRepository, IStudentsRepository studentsRepository, IEnrollmentRepository enrollmentRepository)
        {
            _subjectRepository = subjectRepository;
            _studentsRepository = studentsRepository;
            _enrollmentRepository = enrollmentRepository;
        }

        public Task<Enroll> Handle(EnrollStudentCommad request, CancellationToken cancellationToken)
        {
            var lecture = _enrollmentRepository.EnrollStudents(request.Content);
            return Task.FromResult(lecture);
        }
    }
}
