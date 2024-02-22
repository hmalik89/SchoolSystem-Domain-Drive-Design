using Domain.Entities;
using Infrastrucutre;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SchoolSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            return _context.Students.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            var student = _context.Students.Find(id);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }

        [HttpPost]
        public ActionResult<Student> CreateStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetStudent), new { id = student.StudentId }, student);
        }

        [HttpGet("{studentId}/subjects")]
        public ActionResult<IEnumerable<Subject>> GetSubjectsForStudent(int studentId)
        {
            var student = _context.Students.Include(s => s.Enrollments).ThenInclude(e => e.Subject).FirstOrDefault(s => s.StudentId == studentId);

            if (student == null)
            {
                return NotFound("Student not found.");
            }

            var subjects = student.Enrollments.Select(e => e.Subject).ToList();
            return subjects;
        }
    }
}
