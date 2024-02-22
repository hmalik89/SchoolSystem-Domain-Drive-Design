using Application.Commands.CreateLectures;
using Application.Queries.GetLectures;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public sealed class LecturesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LecturesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[Authorize]
        //[HttpGet]
        //public ActionResult<IEnumerable<Lecture>> GetLecturesForSubject(int subjectId)
        //{
        //    var lectures = _context.Lectures.Where(l => l.SubjectId == subjectId).ToList();

        //    if (lectures == null || lectures.Count == 0)
        //    {
        //        return NotFound();
        //    }

        //    return lectures;
        //}

        //[HttpGet("{id}")]
        //public ActionResult<Lecture> GetLectureForSubject(int subjectId, int id)
        //{
        //    var lecture = _context.Lectures.FirstOrDefault(l => l.SubjectId == subjectId && l.LectureId == id);

        //    if (lecture == null)
        //    {
        //        return NotFound();
        //    }

        //    return lecture;
        //}


        [Authorize]
        [HttpPost]
        public async Task<Lecture> CreateLectureForSubject([FromBody] CreateLectureForSubject command,
            CancellationToken cancellationToken)
        {
            var Lecture = await _mediator.Send(command);
            return Lecture;
        }

        [Authorize]
        [HttpGet]
        public async Task<Lecture> GetLectureForSubject(int subjectId, int id, CancellationToken cancellationToken)
        {
            var query = new GetLectureForSubject(subjectId, id);
            var reponse = await _mediator.Send(query, cancellationToken);
            return reponse;
        }

        //[Authorize]
        //[HttpGet]
        //public async Task<IEnumerable<Lecture>> GetLecturesForSubject(int subjectId, CancellationToken cancellationToken)
        //{
        //    return Lecture
        //}
    }
}
