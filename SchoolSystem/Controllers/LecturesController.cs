using Application.Commands.CreateLectures;
using Application.Queries.GetLectures;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SchoolSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public sealed class LecturesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LecturesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost()]
        public async Task<Lecture> CreateLectureForSubject([FromBody] CreateLectureForSubject command,
            CancellationToken cancellationToken)
        {
            var Lecture = await _mediator.Send(command);
            return Lecture;
        }

        [HttpGet("{subjectId}/{id}")]
        public async Task<Lecture> GetLectureForSubject(int subjectId, int id, CancellationToken cancellationToken)
        {
            var query = new GetLectureForSubject(id, subjectId);
            var reponse = await _mediator.Send(query, cancellationToken);
            return reponse;
        }
    }
}
