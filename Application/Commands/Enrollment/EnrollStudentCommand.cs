

using MediatR;
using Domain.Entities;

namespace Application.Commands.Enrollment
{
    public sealed record EnrollStudentCommad(Enroll Content) : IRequest<Enroll>;
}
