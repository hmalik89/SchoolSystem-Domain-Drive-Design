
using Domain.Entities;
using MediatR;

namespace Application.Commands.CreateLectures
{
    public sealed record CreateLectureForSubject(Lecture Content) : IRequest<Lecture>;
}
