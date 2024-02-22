using Domain.Abstractions;
using Domain.Entities;
using MediatR;

namespace Application.Commands.CreateLectures
{
    internal sealed class CreateLectureForSubjectCommandHandler : IRequestHandler<CreateLectureForSubject, Lecture>
    {
        ILecturesRepository _lecturesRepository;

        public CreateLectureForSubjectCommandHandler(ILecturesRepository lecturesRepository)
        {
            _lecturesRepository = lecturesRepository;
        }

        public Task<Lecture> Handle(CreateLectureForSubject request, CancellationToken cancellationToken)
        {
            var lecture = _lecturesRepository.CreateLectureForSubject(request.Content.SubjectId, request.Content);
            return Task.FromResult(lecture);
        }
    }
}