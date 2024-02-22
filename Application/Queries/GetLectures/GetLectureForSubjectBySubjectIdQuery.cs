using Domain.Entities;
using MediatR;

namespace Application.Queries.GetLectures
{
    public sealed record GetLectureForSubject(int Id, int SubjectId) : IRequest<Lecture>;

}
