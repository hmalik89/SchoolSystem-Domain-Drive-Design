using Application.Commands.CreateLectures;
using Domain.Abstractions;
using Domain.Entities;
using MediatR;
using System.Data;

namespace Application.Queries.GetLectures
{
    public sealed class GetLectureForSubjectByIdQueryHandler : IRequestHandler<GetLectureForSubject, Lecture>
    {
        ILecturesRepository _lecturesRepository;
        public GetLectureForSubjectByIdQueryHandler(ILecturesRepository lecturesRepository)
        {
            _lecturesRepository = lecturesRepository;
        }

        public Task<Lecture> Handle(GetLectureForSubject request, CancellationToken cancellationToken)
        {
            var lecture = _lecturesRepository.GetLectureForSubject(request.SubjectId, request.Id);
            return Task.FromResult(lecture);
        }
    }
}
