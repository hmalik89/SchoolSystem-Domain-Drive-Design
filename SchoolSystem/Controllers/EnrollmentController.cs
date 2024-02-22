using Application.Commands.CreateLectures;
using Application.Commands.Enrollment;
using Application.Queries.GetLectures;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SchoolSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public sealed class EnrollmentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EnrollmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<Enroll> EnrollStudents([FromBody] EnrollStudentCommad command,
            CancellationToken cancellationToken)
        {
            var enroll = await _mediator.Send(command);
            return enroll;
        }

    }
}
