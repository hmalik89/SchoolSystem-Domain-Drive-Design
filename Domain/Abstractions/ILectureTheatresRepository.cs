using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    public interface ILectureTheatresRepository
    {
        IEnumerable<LectureTheatre> GetLectureTheatres();
        LectureTheatre GetLectureTheatre(int id);
        LectureTheatre CreateLectureTheatre(LectureTheatre theatre);
    }
}
