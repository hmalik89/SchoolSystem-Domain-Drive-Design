

using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public sealed class LectureTheatresController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LectureTheatresController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }

    //[ApiController]
    //[Route("api/[controller]")]
    //public class LectureTheatresController : ControllerBase
    //{
    //    private readonly ApplicationDbContext _context;
    //    public LectureTheatresController(ApplicationDbContext context)
    //    {
    //        _context = context;
    //    }

    //    [HttpGet]
    //    public ActionResult<IEnumerable<LectureTheatre>> GetLectureTheatres()
    //    {
    //        return _context.LectureTheatres.ToList();
    //    }

    //    [HttpGet("{id}")]
    //    public ActionResult<LectureTheatre> GetLectureTheatre(int id)
    //    {
    //        var theatre = _context.LectureTheatres.Find(id);

    //        if (theatre == null)
    //        {
    //            return NotFound();
    //        }

    //        return theatre;
    //    }

    //    [HttpPost]
    //    public ActionResult<LectureTheatre> CreateLectureTheatre(LectureTheatre theatre)
    //    {
    //        _context.LectureTheatres.Add(theatre);
    //        _context.SaveChanges();

    //        return CreatedAtAction(nameof(GetLectureTheatre), new { id = theatre.LectureTheatreId }, theatre);
    //    }
    //}
}
