

using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public sealed class SubjectsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SubjectsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //    private readonly ApplicationDbContext _context;
        //    public SubjectsController(ApplicationDbContext context)
        //    {
        //        _context = context;
        //    }

        [HttpGet]
        public async Task<IEnumerable<Subject>> GetSubjects()
        {
            return null;
        }

        //    [HttpGet("{id}")]
        //    public ActionResult<Subject> GetSubject(int id)
        //    {
        //        var subject = _context.Subjects.Find(id);

        //        if (subject == null)
        //        {
        //            return NotFound();
        //        }

        //        return subject;
        //    }

        //    [HttpPost]
        //    public ActionResult<Subject> CreateSubject(Subject subject)
        //    {
        //        _context.Subjects.Add(subject);
        //        _context.SaveChanges();

        //        return CreatedAtAction(nameof(GetSubject), new { id = subject.SubjectId }, subject);
        //    }

        //    [HttpGet("{subjectId}/students")]
        //    public ActionResult<IEnumerable<Student>> GetStudentsForSubject(int subjectId)
        //    {
        //        var subject = _context.Subjects.Include(s => s.Enrollments).ThenInclude(e => e.Student).FirstOrDefault(s => s.SubjectId == subjectId);

        //        if (subject == null)
        //        {
        //            return NotFound("Subject not found.");
        //        }

        //        var students = subject.Enrollments.Select(e => e.Student).ToList();
        //        return students;
        //    }
        //}
    }
}
