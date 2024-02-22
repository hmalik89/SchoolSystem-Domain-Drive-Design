using Domain.Entities;
using Infrastrucutre;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SchoolSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubjectsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public SubjectsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Subject>> GetSubjects()
        {
            return _context.Subjects.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Subject> GetSubject(int id)
        {
            var subject = _context.Subjects.Find(id);

            if (subject == null)
            {
                return NotFound();
            }

            return subject;
        }

        [HttpPost]
        public ActionResult<Subject> CreateSubject(Subject subject)
        {
            _context.Subjects.Add(subject);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetSubject), new { id = subject.SubjectId }, subject);
        }

        [HttpGet("{subjectId}/students")]
        public ActionResult<IEnumerable<Student>> GetStudentsForSubject(int subjectId)
        {
            var subject = _context.Subjects.Include(s => s.Enrollments).ThenInclude(e => e.Student).FirstOrDefault(s => s.SubjectId == subjectId);

            if (subject == null)
            {
                return NotFound("Subject not found.");
            }

            var students = subject.Enrollments.Select(e => e.Student).ToList();
            return students;
        }
    }
}
